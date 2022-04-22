using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    class Presenter
    {
        private IView _view = null;
        private IModel _model = null;

        public Presenter (IView view, IModel model)
        {
            _view = view;
            _model = model;

            _view.OnUpdateModel += ViewModelUpdate;
            _view.CharacterUpdated += ViewModelCharacterUpdate;
            _view.Shooted += ViewModelShoot;

            _model.Updated += ModelViewUpdate;
        }

        private void ViewModelShoot(object sender, ShootEventArgs e)
        {
            _model.Shoot(e.Position);
        }

        public IView ShowView()
        {
            return _view;
        }

        private void ModelViewUpdate(object sender, ModelUpdatedEventArgs e)
        {
            _view.Draw(e.Pos, e.bullets, e.enemies);
        }

        private void ViewModelCharacterUpdate(object sender, CharacterEventArgs e)
        {
            _model.UpdateCharacter(e.Position);
        }

        private void ViewModelUpdate(object sender, EventArgs e)
        {
            _model.Update();
        }
    }
}
