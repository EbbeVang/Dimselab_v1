using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimselab_v1
{
    class Project
    {
        private String _name;
        private String _description;

        private ObservableCollection<Participant> _participants = new ObservableCollection<Participant>();

        public Project(String name, String description)
        {
            this._name = name;
            this._description = description;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public ObservableCollection<Participant> Participants
        {
            get { return _participants; }
            set { _participants = value; }
        }
    }
}
