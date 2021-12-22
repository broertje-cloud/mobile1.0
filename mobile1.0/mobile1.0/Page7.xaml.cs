using mobile1._0.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobile1._0
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page7 : ContentPage
    {
        public Page7()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection sQLiteConnection = new SQLiteConnection(App.DatabaseLocation))
            {
                sQLiteConnection.CreateTable<Question>();
                var question = sQLiteConnection.Table<Question>().ToList();
                QuestionListView.ItemsSource = question;
            }
        }
        private void HomeButton_Clicked_1(object sender, EventArgs e)
            {
                Navigation.PushAsync(new Homepage());
            }

            private void QuestionListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
            Question selectedQuestion = QuestionListView.SelectedItem as Question;
            if (selectedQuestion != null)
            {
                Navigation.PushAsync(new QuestionDetailPage(selectedQuestion));
            }
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            Question question = new Question
            {
                QuestionBody = QuestionEntry.Text
            };

            SQLiteConnection sQLiteConnection = new SQLiteConnection(App.DatabaseLocation);
            sQLiteConnection.CreateTable<Question>();
            int insertedRows = sQLiteConnection.Insert(question);
            sQLiteConnection.Close();

            if (insertedRows > 0)
            {
                _ = DisplayAlert("Gelukt", "je vraag is goed toegevoegd aan de database", "ok");
            }
            else
            {
                _ = DisplayAlert("Ah, jammer! Er ging iets fout", "Je vraag is NIET toegevoegd aan de database.", "ok");

            }

            await Navigation.PopAsync();

        }
    }



}
