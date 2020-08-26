using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.Model
{
    public class UserInfoModel : ObservableObject
    {
        private String userName;
        /// <summary>
        /// User Name
        /// </summary>
        public String UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(() => UserName); }
        }

        private Int64 userPhone;
        /// <summary>
        /// the phone number
        /// </summary>
        public Int64 UserPhone
        {
            get { return userPhone; }
            set { userPhone = value; RaisePropertyChanged(() => UserPhone); }
        }

    }
}
