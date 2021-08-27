<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128592427/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E300)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [SelectRecordInLookupViewController.cs](./CS/WinSolution.Module.Win/SelectRecordInLookupViewController.cs) (VB: [SelectRecordInLookupViewController.vb](./VB/WinSolution.Module.Win/SelectRecordInLookupViewController.vb))
* [SelectRecordInLookupViewController.Designer.cs](./CS/WinSolution.Module.Win/SelectRecordInLookupViewController.Designer.cs) (VB: [SelectRecordInLookupViewController.Designer.vb](./VB/WinSolution.Module.Win/SelectRecordInLookupViewController.Designer.vb))
<!-- default file list end -->
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


