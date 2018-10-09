using System;
using MVVMDemoApplication.Model;

namespace MVVMDemoApplication.ViewModel
{
    /// <summary>
    /// ViewModel class for the Person model object
    /// </summary>
    public class PersonViewModel : ViewModelBase
    {
        #region fields
        // wrapped Person object
        private readonly Person person;
        #endregion

        /// <summary>
        /// Create a new instance of the PersonViewModel class
        /// </summary>
        /// <param name="person">Wrapped person object</param>
        public PersonViewModel(Person person)
        {
            if(person == null)
                throw new NullReferenceException("person");

            this.person = person;
        }

        #region properties
        /// <summary>
        /// Gets or sets the first name of the person
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.person.FirstName;
            }
            set
            {
                this.person.FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Gets or sets the last name of the person
        /// </summary>
        public string LastName
        {
            get
            {
                return this.person.LastName;
            }
            set
            {
                this.person.LastName = value;
                OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating wheter the person is a male
        /// </summary>
        public bool IsMale
        {
            get
            {
                return this.person.Gender == Gender.Male;
            }
            set
            {
                if (value)
                    this.person.Gender = Gender.Male;
                else
                    this.person.Gender = Gender.Female;

                OnPropertyChanged("IsMale");
                OnPropertyChanged("IsFemale");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating wheter the person is a female
        /// </summary>
        public bool IsFemale
        {
            get
            {
                return this.person.Gender == Gender.Female;
            }
            set
            {
                if (value)
                    this.person.Gender = Gender.Female;
                else
                    this.person.Gender = Gender.Male;

                OnPropertyChanged("IsFemale");
                OnPropertyChanged("IsMale");
            }
        }

        /// <summary>
        /// Gets or sets the age of the person
        /// </summary>
        public int Age
        {
            get
            {
                return this.person.Age;
            }
            set
            {
                this.person.Age = value;
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Gets the wrapped Person object
        /// </summary>
        public Person Person
        {
            get
            {
                return this.person;
            }
        }
        #endregion
    }
}
