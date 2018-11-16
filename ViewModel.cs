using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dimselab_v1.Annotations;

namespace Dimselab_v1
{
    class ViewModel : INotifyPropertyChanged
    {
        public Project _selectedProject;

        private ObservableCollection<Project> _projects = new ObservableCollection<Project>();

        public event PropertyChangedEventHandler PropertyChanged;

        public Project SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value; 
                OnPropertyChanged();
                Debug.WriteLine("selected project changed");
            }
        }

        public ObservableCollection<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }


        public ViewModel()
        {
            Debug.WriteLine("Viewmodel constructor");
            Projects.Add(new Project("Build robot", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed at cursus sapien. Sed fringilla fringilla semper. In hac habitasse platea dictumst. Pellentesque vitae nisl ultricies, accumsan tellus a, viverra augue. Quisque vel dui tristique, ornare tortor in, commodo massa. Fusce auctor tortor id dui lobortis."));
            Projects.Add(new Project("3d designs", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam vitae interdum est. Cras nunc odio, efficitur vitae vestibulum in, pharetra sed velit. Quisque congue luctus diam, a rhoncus leo vulputate et. Donec sit amet volutpat velit. Nam ut dui in erat facilisis laoreet ac et augue. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aenean in ipsum blandit, sodales risus."));
            Projects.Add(new Project("RC car", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi consequat convallis sapien, a ullamcorper odio. Nunc nec mi quis quam lacinia dictum. Sed fringilla a dui in venenatis. Phasellus neque velit, feugiat at nibh a, maximus hendrerit orci. Maecenas efficitur magna id arcu egestas laoreet. Nulla ac urna venenatis velit finibus malesuada nec in lacus. Mauris dui nibh, cursus vel est sit amet, vestibulum lobortis."));

            Projects[0].Participants.Add(new Participant("Adam"));
            Projects[0].Participants.Add(new Participant("Bob"));

            SelectedProject = Projects[0];
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
