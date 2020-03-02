using UnityEngine;

public class AKSpawner : MonoBehaviour
{
    private IAK m_Basic;
    private IAK m_ReflexSight;
    private IAK m_Stock;
    private IAK m_Grip;
    private IAK m_Silencer;
    private IAK m_Drum;
    private AbstractFactory factory;

    public void SpawnBasicAK()
    {
        factory = FactoryProducer.GetFactory(FactoryType.AK);
        m_Basic = factory.GetAK(AttachmentType.Basic);
        Debug.Log("Accuracy: " + m_Basic.GetAccuracy());
        Debug.Log("Ammo: " + m_Basic.GetAmmo());
    }
    public void SpawnAKwReflexSight()
    {
        factory = FactoryProducer.GetFactory(FactoryType.AK);
        m_ReflexSight = factory.GetAK(AttachmentType.ReflexSight);
        Debug.Log("Accuracy: " + m_Basic.GetAccuracy());
        Debug.Log("Ammo: " + m_Basic.GetAmmo());
    }

    public void SpawnAKwStock()
    {
        factory = FactoryProducer.GetFactory(FactoryType.AK);
        m_Stock = factory.GetAK(AttachmentType.Stock);
        Debug.Log("Accuracy: " + m_Basic.GetAccuracy());
        Debug.Log("Ammo: " + m_Basic.GetAmmo());
    }

    public void SpawnAKwRGrip()
    {
        factory = FactoryProducer.GetFactory(FactoryType.AK);
        m_Grip = factory.GetAK(AttachmentType.Grip);
        Debug.Log("Accuracy: " + m_Basic.GetAccuracy());
        Debug.Log("Ammo: " + m_Basic.GetAmmo());
    }

    public void SpawnAKwRSilencer()
    {
        factory = FactoryProducer.GetFactory(FactoryType.AK);
        m_Silencer = factory.GetAK(AttachmentType.Silencer);
        Debug.Log("Accuracy: " + m_Basic.GetAccuracy());
        Debug.Log("Ammo: " + m_Basic.GetAmmo());
    }

    public void SpawnAKwDrum()
    {
        factory = FactoryProducer.GetFactory(FactoryType.AK);
        m_Drum = factory.GetAK(AttachmentType.Drum);
        Debug.Log("Accuracy: " + m_Basic.GetAccuracy());
        Debug.Log("Ammo: " + m_Basic.GetAmmo());
    }
}