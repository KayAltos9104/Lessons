using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_2
{
    public class Presenter
    {
        private IView _view = null;
        private IModel _model = null;
        public Presenter (IModel model, IView view)
        {
            _view = view;
            _model = model;
            _view.Initialized += ViewInitModel;
            _model.Moved += ModelChangedView;
        }   
        public void ViewInitModel(object sender, EventArgs e)
        {
            _model.Init();
        }
        public void ModelChangedView (object sender, MovedEventArgs e)
        {
            _view.Render(e.X, e.Y, e.Radius);
        }
    }
}
