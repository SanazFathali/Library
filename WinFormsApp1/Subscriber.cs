using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Subscriber
    {
        #region Fields
        private string _firstname;
        private string _lastname;
        private string _cellphone;
        private string _code;
        #endregion

        #region Properties
        public string FirstName
		{
			get { return _firstname; }
			set { _firstname = value; }
		}

	

		public string LastName
		{
			get { return _lastname; }
			set { _lastname = value; }

		}

		

		public string CellPhone
		{
			get 
			{ 
				return _cellphone; 
			}
			set 
			{
				if (value.Length<10)
				{
					throw new ArgumentException("number is incorrect ");


				}

				else
				{
					_cellphone = value;							
				}
				
			}
		}

		
		public string Code
		{
			get { return _code; }
			set { _code = value; }
		}
        #endregion


		public Subscriber()
		{
		}

		public Subscriber(string firstname, string lastname, string cellphone, string code)

		{
			_firstname = firstname;	
			_lastname = lastname;
			_cellphone = cellphone;
			_code = code;

		}




    }
}
