using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.SystemModule;

namespace AuditDemo.Module.Win {
    public partial class SelectRecordInLookupViewController : ViewController<ListView> {
        public SelectRecordInLookupViewController() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void saSelectRecordInLookup_Execute(object sender, SimpleActionExecuteEventArgs e) {
            ListViewProcessCurrentObjectController listViewProcessCurrentObjectController = Frame.GetController<ListViewProcessCurrentObjectController>();
            if (listViewProcessCurrentObjectController != null) {
                SimpleAction processCurrentObjectAction = Frame.GetController<ListViewProcessCurrentObjectController>().ProcessCurrentObjectAction;
                if (processCurrentObjectAction.Active.ResultValue && processCurrentObjectAction.Enabled.ResultValue) {
                    processCurrentObjectAction.DoExecute();
                }
            }
        }
    }
}
