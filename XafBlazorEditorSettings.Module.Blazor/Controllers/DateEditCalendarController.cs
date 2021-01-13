using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;

using System;
using XafBlazorEditorSettings.Module.BusinessObjects;

namespace XafBlazorEditorSettings.Module.Blazor.Controllers
{
    public  class DateEditCalendarController : ObjectViewController<DetailView, Customer>
    {
        public DateEditCalendarController()
        {
           
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            View.CustomizeViewItemControl<DateTimePropertyEditor>(this, SetCalendarView, nameof(Customer.DoB));
        }
        private void SetCalendarView(DateTimePropertyEditor propertyEditor)
        {
            try
            {
                var dateEditAdapter = (DxDateEditAdapter<DateTime>)propertyEditor.Control;
                dateEditAdapter.ComponentModel.PickerDisplayMode = DevExpress.Blazor.DatePickerDisplayMode.ScrollPicker;
            }
            catch (Exception ex)
            {

                var test = ex.Message;
            }
         
        }
    }
}
