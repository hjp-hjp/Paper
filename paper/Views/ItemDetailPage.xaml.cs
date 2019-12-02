using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using paper.Models;
using paper.ViewModels;

namespace paper.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private async System.Threading.Tasks.Task Add_ClickedAsync(object sender, EventArgs e)
        {
            //将题目添加到题目暂存区，待实现/*****
            /*待实现代码区*/
            /********/
            //弹出提示窗口
            await DisplayAlert("提示", "添加成功", "确认");
        }

        
    }
}