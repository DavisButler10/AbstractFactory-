using UnityEngine;

public class FactoryProducer : MonoBehaviour
{
    public static AbstractFactory GetFactory(FactoryType factoryType)
    {
        switch (factoryType)
        {
            case FactoryType.AK:
                AbstractFactory akFactory = new AKFactory();
                return akFactory;
        }
        return null;
    }
}