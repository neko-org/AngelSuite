/*
    Copyright � 2009, Aion-Radar.com
    All rights reserved.
    http://www.aion-radar.com


    This file is part of Aion Radar.

    Aion Radar is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Aion Radar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Aion Radar.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetesAionRadar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Auto-update and restart if an update was applied, otherwise
            // launch the application normally.
            StartPetesAionRadar();
        }
            /*try
            {
                AutoUpdate.RemotePath = "http://www.Aion-Radar.com/AutoUpdate/";
                AutoUpdate.UpdateFileName = "AutoUpdate.txt";

                switch (AutoUpdate.UpdateFiles(AutoUpdate.RemotePath, Utils.GetAppSetting("AutoUpdateDebug") == "True"))
                {
                    case AutoUpdate.UpdateStatus.NothingToUpdate:
                    case AutoUpdate.UpdateStatus.ErrorInAutoUpdate:
                    case AutoUpdate.UpdateStatus.ErrorAtServer:
                    case AutoUpdate.UpdateStatus.UpdateMismatch:
                    default:
                        StartPetesAionRadar();
                        break;

                    case AutoUpdate.UpdateStatus.NoConnectionToServer:
                        MessageBox.Show("AutoUpdate could not connect to the remote server to\r\nmake sure you are running the latest version.\r\n\r\nPlease check that your internet connection is working.", "AutoUpdate Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        StartPetesAionRadar();
                        break;

                    case AutoUpdate.UpdateStatus.UpdatedSuccessfully:
                        Utils.DoGarbageCollection();
                        Application.Restart();
                        return;
                }
            }
            catch
            {
                StartPetesAionRadar();
            }
        }*/

        static void StartPetesAionRadar()
        {
            Application.Run(new frmMain());
        }
    }
}