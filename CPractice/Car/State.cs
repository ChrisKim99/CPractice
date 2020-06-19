using System;
using System.Collections.Generic;
using System.Text;

namespace CPractice.Car
{
    abstract class State
    {
        public State(car car) {
             void ShiftToDrive() { }
             void ShiftToPark() { }
             void ShiftToReverse() { }
             void Accelerate() { }
             void Brake() { }
             void Velocity(int v) { }
        }
        

    }
}
