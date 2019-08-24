﻿using System;
using System.Windows.Forms;
using InterpreterClassLibrary;
using OSGViewClassLibrary;

namespace Shoot
{
    public partial class GameForm : Form
    {
        private OSGViewClassWrapper osgWrapper = new OSGViewClassWrapper();

        public GameForm(MissionDatabase.Data mission)
        {
            InitializeComponent();
            this.title.Text = mission.name;
            this.Text = mission.name;
            this.missionNote.Text = mission.note;

            string content = FileReadWrite.ReadFile(this.Text.ToString());
            if (content != null)
                this.codeText.Text = content;
            else
                this.codeText.Text = mission.code;

            osgWrapper.SetMission(mission.number);

            renderArea.Paint += new PaintEventHandler(Painter);
        }

        private void Painter(object sender, PaintEventArgs e)
        {
            // Renders the OSG Viewer into the drawing area
            osgWrapper.Render(renderArea.Handle);
        }

        private void CallWrapper (string file)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(file);

            unsafe
            {
                fixed (byte* p = bytes)
                {
                    sbyte* sp = (sbyte*)p;
                    InterpreterClassWrapper wrapper = new InterpreterClassWrapper(sp);
                }
            }
        }

        private void run_Click(object sender, System.EventArgs e)
        {
            string content = this.codeText.Text.ToUpper();
            string file = FileReadWrite.WriteFile(content, this.Text.ToString());
            CallWrapper(file);
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            string content = this.codeText.Text.ToUpper();
            FileReadWrite.WriteFile(content, this.Text.ToString());
        }

        private void back_Click(object sender, EventArgs e)
        {
            renderArea.Paint -= Painter;
            osgWrapper.Destroy();
            UiManager.CloseGameForm();
        }
    }
}