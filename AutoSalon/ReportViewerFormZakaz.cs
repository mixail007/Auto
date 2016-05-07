using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaikovBSUIR {
    public partial class ReportViewerFormZakaz : Form {
        public ReportViewerFormZakaz() {
            InitializeComponent();
        }

        private void ReportViewerFormZakaz_Load(object sender, EventArgs e) {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e) {

        }
    }
}
