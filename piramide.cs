
namespace Piramide{
    public static class Piramide {

        public static int Piani( int mattoni )
        {   
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

            while (mattoni > 8){
                mattoni = mattoni  - 8;
                piani++;
            }

            piani++;


            return piani;
        }
        public static int Rimanenti( int mattoni )
        {
            return 0;
        }

    }
}