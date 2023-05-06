
namespace Piramide{
    public static class Piramide {

        public static int Piani( int mattoni )
        {   
            int molti = 0;
            int temp = 1;
            int piani = 0;

            if (mattoni == 0){
                return 0;
            }
            if (mattoni == 1){
                piani = 1;
                return piani;
            }
            if (mattoni < 0){
                return 0;
            }

            
            do {
                if (temp > mattoni){
                    break;
                }
                temp = temp + 8*molti;
                molti = molti + 1;
                mattoni = mattoni - temp;
                piani++;
                if (mattoni <= 7){
                    break;
                }
                
            }while (mattoni > 8 && piani >= 1);

            

            return piani;
        }
        public static int Rimanenti( int mattoni )
        {   
            int molti = 0;
            int temp = 1;
            int piani = 0;

            if (mattoni == 0){
                return 0;
            }
            if (mattoni == 1){
                piani = 0;
                return piani;
            }
            if (mattoni < 0){
                return 0;
            }

            do {
                if (temp > mattoni){
                    break;
                }
                temp = temp + 8*molti;
                molti = molti + 1;
                mattoni = mattoni - temp;
                piani++;
                if (mattoni <= 7){
                    break;
                }
                
            }while (mattoni > 8 && piani >= 1);
            return mattoni;
        }

    }
}
