// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Appathon {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class ShellView : ContentPage {
        
        private ColumnDefinition MenuColumn;
        
        private Button MenuToggleButton;
        
        private ContentView ContentControl;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(ShellView));
            MenuColumn = this.FindByName <ColumnDefinition>("MenuColumn");
            MenuToggleButton = this.FindByName <Button>("MenuToggleButton");
            ContentControl = this.FindByName <ContentView>("ContentControl");
        }
    }
}
