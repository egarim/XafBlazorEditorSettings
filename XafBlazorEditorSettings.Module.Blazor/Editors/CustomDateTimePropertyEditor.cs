using System;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;

namespace XafBlazorEditorSettings.Module.Blazor.Editors
{
    [PropertyEditor(typeof(DateTime), false)]
    public class CustomDateTimePropertyEditor : DateTimePropertyEditor
    {
        public CustomDateTimePropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override void OnControlCreated()
        {
            base.OnControlCreated();
            switch (Control)
            {
                case DxDateEditAdapter<DateTime?> adapter:
                    adapter.ComponentModel.TimeSectionVisible = true;
                    break;
                case DxDateEditAdapter<DateTime> adapter:
                    adapter.ComponentModel.TimeSectionVisible = true;
                    break;
            }
        }
    }
}
