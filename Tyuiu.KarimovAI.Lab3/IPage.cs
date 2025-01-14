using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KarimovAI.Lab3.Review.V13
{
    public interface IPage
    {

        private void Render()
        {
            throw new NotImplementedException();
        }
        public void UpButtonPressed();

        public void DownButtonPressed();
        public IPage F1ButtonPressed();
        public IPage EscButtonPressed();

        public void NumberPressed(int value);
        public IPage EnterButtonPressed();

    }
}
