public class Bus {
    public void ArrangeRiders(int[] chairs) {
        int ticketConductor = 0;
        
        for(int rider = 0; rider < chairs.Length; rider++) {
            // if the rider has a ticke "Not has 0 ticket" :
            if(chairs[rider] != 0) { 
                chairs[ticketConductor] = chairs[rider];
                ticketConductor++;
            }
        }
        
        while(ticketConductor < chairs.Length) {
            chairs[ticketConductor] = 0;
            ticketConductor++;
        }
    }
}