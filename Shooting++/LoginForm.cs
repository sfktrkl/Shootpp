﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InterpreterClassLibrary;


namespace Shooting__
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UiManager.Init(this);
        }

        private void start_Click(object sender, EventArgs e)
        {
            string id = idBox.Text.ToString();
            string pw = pwBox.Text.ToString();

            if (id.Length < 5)
            {
                MessageBox.Show("ID is too short", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pw.Length < 5)
            {
                MessageBox.Show("PW is too short", "PW Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var condition = FileReadWrite.CheckLoginFile(id, pw);

            if (condition == FileReadWrite.FileCondition.DirectoryNotExist)
            {
                if (MessageBox.Show("Account could not find. " +
                    "\nDo you want to create now?? " +
                    "\nYour ID: " + id + " and your PW: " + pw,
                    "No User Account", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    FileReadWrite.WriteLoginFile(new List<string> { id, pw, "0" }, id, pw);
                }
            }
            else if (condition == FileReadWrite.FileCondition.FileNotExist)
            {
                if (MessageBox.Show("File could not find. Please check your save file. " +
                                    "\nOr Do you want to register?" +
                                    "\nYour ID: " + id + " and your PW: " + pw,
                                    "No User File", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    FileReadWrite.WriteLoginFile(new List<string> { id, pw, "0" }, id, pw);
                }
            }
            else if (condition == FileReadWrite.FileCondition.FileExist)
            {
                List<string> read = FileReadWrite.ReadLoginFile(id, pw);

                if (HashGenerator.VerifyHash(read[0], id) && HashGenerator.VerifyHash(read[1], pw))
                {
                    UiManager.CreateMissionForm();
                }
                else
                {
                    MessageBox.Show("Your password is wrong!!", "WRONG PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Something gone wrong.", "Unkown Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            UiManager.CloseForm();
        }
    }
}