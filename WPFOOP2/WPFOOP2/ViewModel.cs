using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFOOP2
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Model model;

        public event PropertyChangedEventHandler PropertyChanged;

        public string timesClickedString 
        { 
            get {return model.timesClicked.ToString();}
            set { }
        }

        public string headsTailsString
        {
            get { return model.headsTailsString; }
            set { }
        }

        public int timesFlipped
        {
            get { return model.timesFlipped; }
            set { }
        }

        public string dateString
        {
            get { return model.dateString; }
            set { }
        }

        public string nameString
        {
            get { return model.nameString; }
            set { }
        }

        public int firstNumber
        {
            get { return model.firstNumber; }
            set { }
        }

        public int secondNumber
        {
            get { return model.secondNumber; }
            set { }
        }

        public string resultString
        {
            get { return model.resultString; }
            set { }
        }
       
        public ViewModel(Model m)
        {
            model = m;
        }

        public void IncrementTimesClicked()
        {
            model.IncrementTimesClicked();
        }

        public void GetHeadsOrTails()
        {
            model.SetHeadsOrTails();
        }

        public void SetDate()
        {
            model.SetDate();
        }

        public void SetRandomNumbers()
        {
            model.SetRandomNumbers();
        }

        public void SetResultString(string answer)
        {
            model.SetResultString(answer);
        }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
