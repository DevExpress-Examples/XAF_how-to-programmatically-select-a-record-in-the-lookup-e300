# How to programmatically select a record in the lookup


<p>By default when a user moves the mouse in the lookup the selection follows the cursor, and when a user clicks on a record it is selected as a value of the lookup property editor. This is a built-in functionality of the lookup property editor. If you want to utilize this functionality, you can use the <a href="http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppSystemModuleListViewProcessCurrentObjectControllertopic"><u>ListViewProcessCurrentObjectController</u></a> as shown below:</p>
<br> <br>


```cs
using DevExpress.ExpressApp;<newline/>
using DevExpress.ExpressApp.Actions;<newline/>
using DevExpress.ExpressApp.SystemModule;<newline/>
<newline/>
namespace AuditDemo.Module.Win {<newline/>
    public partial class SelectRecordInLookupViewController : ViewController<ListView> {<newline/>
        public SelectRecordInLookupViewController() {<newline/>
            InitializeComponent();<newline/>
            RegisterActions(components);<newline/>
        }<newline/>
        private void saSelectRecordInLookup_Execute(object sender, SimpleActionExecuteEventArgs e) {<newline/>
            ListViewProcessCurrentObjectController listViewProcessCurrentObjectController = Frame.GetController<ListViewProcessCurrentObjectController>();<newline/>
            if (listViewProcessCurrentObjectController != null) {<newline/>
                SimpleAction processCurrentObjectAction = listViewProcessCurrentObjectController.ProcessCurrentObjectAction;<newline/>
                if (processCurrentObjectAction.Active.ResultValue <newline/>
                    && processCurrentObjectAction.Enabled.ResultValue)<newline/>
                    processCurrentObjectAction.DoExecute();<newline/>
                }<newline/>
            }<newline/>
        }<newline/>
    }<newline/>
}<newline/>

```


<p> </p>

<br/>


