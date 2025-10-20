static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
        
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => 
        knightIsAwake || archerIsAwake || prisonerIsAwake;
    
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;
    
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent && CanFastAttack(archerIsAwake))
            return true; 
        else if(IsCondionTwoSatisfied(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent))
            return true; 
       return false;  
    }

    private static bool IsCondionTwoSatisfied(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
     =>   !petDogIsPresent 
           && CanFastAttack(knightIsAwake) 
           && CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
}
