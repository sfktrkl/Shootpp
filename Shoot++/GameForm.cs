﻿using System;
using System.Windows.Forms;
using InterpreterClassLibrary;
using OSGViewClassLibrary;

namespace Shoot
{
    public partial class GameForm : Form
    {
        private OSGViewClassWrapper viewer = new OSGViewClassWrapper();
        private InterpreterClassWrapper interpreter;
        private int[] solutions;
        string[] debugOutputs;
        private Mission mission;
        public static bool isDebugShoot = true;

        public GameForm(Mission mission)
        {
            InitializeComponent();

            this.mission = mission;

            this.title.Text = mission.data.name;
            this.Text = mission.data.name;
            this.missionNote.Text = mission.data.note;

            string content = FileReadWrite.ReadFile(this.Text.ToString());
            if (content != null)
                this.codeText.Text = content;
            else
                this.codeText.Text = mission.data.code;

            solutions = mission.data.solutions;

            viewer.SetMission(mission.data.number);
            GiveInputsToViewer(mission.data.inputs);

            renderArea.Paint += new PaintEventHandler(Painter);
        }

        private void RefreshMission()
        {
            this.mission.RefreshMission();

            solutions = mission.data.solutions;

            viewer.SetMission(mission.data.number);
            GiveInputsToViewer(mission.data.inputs);
        }

        private void Painter(object sender, PaintEventArgs e)
        {
            // Renders the OSG Viewer into the drawing area
            viewer.Render(renderArea.Handle);
        }

        private void CallInterpreter(string file, int[] inputValues)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(file);

            unsafe
            {
                fixed (byte* fileByte = bytes)
                {
                    sbyte* fileString = (sbyte*)fileByte;
                    interpreter = new InterpreterClassWrapper(fileString);
                }

                fixed (int* inputs = inputValues)
                {
                    interpreter.GiveInputs(inputs);
                }
            }

            //Disabled, since debugInfo button takes over the task.
            //interpreter.SetDebugMode(isDebugShoot);

            interpreter.Execute();
        }

        private void GiveOutputsToViewer(int[] outputValues)
        {
            unsafe
            {
                fixed (int* outputs = outputValues)
                {
                    viewer.GiveOutputs(outputs);
                }
            }
        }

        private void GiveInputsToViewer(int[] inputValues)
        {
            unsafe
            {
                fixed (int* inputs = inputValues)
                {
                    viewer.GiveInputs(inputs);
                }
            }
        }

        private void run_Click(object sender, System.EventArgs e)
        {
            RefreshMission();

            string content = this.codeText.Text.ToUpper();
            string file = FileReadWrite.WriteFile(content, this.Text.ToString());
            CallInterpreter(file, mission.data.inputs);

            int[] outputs = interpreter.TakeOutputs();
            debugOutputs = interpreter.TakeDebugOutputs();

            if (UiManager.debugForm != null)
                UiManager.debugForm.GetDebugOutputs(debugOutputs);

            GiveOutputsToViewer(outputs);

            bool success = true;

            for (int i = 0; i < outputs.Length; i++)
            {
                if (outputs[i] != solutions[i])
                {
                    success = false;
                    break;
                }
            }

            viewer.SetSuccess(success);

            viewer.Refresh();
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            string content = this.codeText.Text.ToUpper();
            FileReadWrite.WriteFile(content, this.Text.ToString());
        }

        private void back_Click(object sender, EventArgs e)
        {
            renderArea.Paint -= Painter;
            viewer.Destroy();
            UiManager.CloseGameForm();
        }

        private void help_Click(object sender, EventArgs e)
        {
            UiManager.CreateHelpForm();
        }

        private void debug_Click(object sender, EventArgs e)
        {
            UiManager.CreateDebugForm(debugOutputs);
        }
    }
}