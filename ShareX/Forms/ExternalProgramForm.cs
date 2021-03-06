﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (C) 2008-2013 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using HelpersLib;
using System;
using System.Windows.Forms;

namespace ShareX
{
    public partial class ExternalProgramForm : Form
    {
        public ExternalProgram FileAction { get; private set; }

        public ExternalProgramForm()
            : this(new ExternalProgram())
        {
        }

        public ExternalProgramForm(ExternalProgram fileAction)
        {
            FileAction = fileAction;
            InitializeComponent();
            txtName.Text = fileAction.Name ?? "";
            txtPath.Text = fileAction.Path ?? "";
            txtArguments.Text = fileAction.Args ?? "";
        }

        private void btnPathBrowse_Click(object sender, EventArgs e)
        {
            Helpers.BrowseFile("ShareX - Choose file path", txtPath);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FileAction.Name = txtName.Text;
            FileAction.Path = txtPath.Text;
            FileAction.Args = txtArguments.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}