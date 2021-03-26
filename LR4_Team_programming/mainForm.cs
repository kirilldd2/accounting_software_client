﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LR4_Team_programming
{
    public partial class mainForm : Form
    {
        Dictionary<TreeNode, Panel> menuToPanel;
        List<Panel> panels;
        // 835; 690 - size
        // 362; 0 - location


        Point locationPanels = new Point(362, 0);
        Size sizePanels = new Size(835, 690);

        public mainForm()
        {
            InitializeComponent();

            inventarizationReportCreatePanel.Location = reportPanel.Location = inventarizationPanel.Location = locationPanels;
            inventarizationReportCreatePanel.Size = reportPanel.Size = inventarizationPanel.Size = sizePanels;

            inventarizationReportCreatePanel.Visible = false;
            reportPanel.Visible = false;
            inventarizationPanel.Visible = false;

            menuToPanel = new Dictionary<TreeNode, Panel>()
            {
                {menuTree.Nodes[0].Nodes[0],  inventarizationReportCreatePanel},
                {menuTree.Nodes[0].Nodes[1],  reportPanel},
                {menuTree.Nodes[1].Nodes[0],  inventarizationPanel}
            };
            panels = new List<Panel>()
            {
                inventarizationReportCreatePanel, reportPanel, inventarizationPanel
            };
        }
    
        private void senderDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                menuToPanel[menuTree.SelectedNode].Visible = true;
                foreach (Panel panel in panels)
                    panel.Visible = false;

                menuToPanel[menuTree.SelectedNode].Visible = true;

            }
            catch
            {
                // :(
            }

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}