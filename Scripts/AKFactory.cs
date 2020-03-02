public class AKFactory : AbstractFactory
{
    public override IAK GetAK(AttachmentType aType)
    {

        IAK currentRifle;

        switch (aType)
        {
            case AttachmentType.Basic:
                IAK rifleBasic = new BasicAK();
                currentRifle = rifleBasic;
                return rifleBasic;
            case AttachmentType.ReflexSight:
                IAK rifleRS = new BasicAK();
                rifleRS = new WithReflexSight(rifleRS);
                currentRifle = rifleRS;
                return rifleRS;
            case AttachmentType.Stock:
                IAK rifleStock = new BasicAK();
                rifleStock = new WithStock(rifleStock);
                currentRifle = rifleStock;
                return rifleStock;
            case AttachmentType.Grip:
                IAK rifleGrip = new BasicAK();
                rifleStock = new WithGrip(rifleGrip);
                currentRifle = rifleGrip;
                return rifleGrip;
            case AttachmentType.Silencer:
                IAK rifleSilencer = new BasicAK();
                rifleStock = new WithSilencer(rifleSilencer);
                currentRifle = rifleSilencer;
                return rifleSilencer;
            case AttachmentType.Drum:
                IAK rifleDrum = new BasicAK();
                rifleDrum = new WithDrum(rifleDrum);
                currentRifle = rifleDrum;
                return rifleDrum;
        }
        return null;
    }
}