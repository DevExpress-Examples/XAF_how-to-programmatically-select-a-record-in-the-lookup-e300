using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace AuditDemo.Module.Win {
    public partial class ViewController1 : ViewController {
        public ViewController1() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            ListView lookupListView = (ListView)View;
            ((SimpleAction)(lookupListView.ProcessSelectedItemAction)).DoExecute();
        }
    }
}
