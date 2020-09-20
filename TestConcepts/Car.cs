using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConcepts
{
    public class Car
    {
        public delegate void SpeedLimitExceededEventHandler(object source, EventArgs e);
        public event SpeedLimitExceededEventHandler SpeedLimitExceeded;
        
        private int _speed = 0;
        private int _safetySpeed = 70;

        public int Speed
        {
            get
            {
                return _speed;
            }
        }

        public void Accelerate(int mph)
        {
            int oldSpeed = _speed;
            _speed += mph;

            if (oldSpeed <= _safetySpeed && _speed > _safetySpeed)
                OnSpeedLimitExceeded(new EventArgs());
        }

        public virtual void OnSpeedLimitExceeded(EventArgs e)
        {
            if (SpeedLimitExceeded != null) SpeedLimitExceeded(this, e);
        }

    }
}
