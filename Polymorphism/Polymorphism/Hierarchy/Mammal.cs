﻿namespace Hierarchy
{
    public abstract class Mammal : Animal

    {

        public Mammal( string animalType, string animalName, double animalWeight, string livingRegion) :
            base(animalType, animalName, animalWeight)
        { }
    }
}
