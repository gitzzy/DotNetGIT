
class ptrn1{
    public static void main(String[] args){
        int n=5;

        for(int i=1; i<=n; i++){
            int space = 3-i;
            int tspace = Math.abs(space);
            int star = 5-(2*tspace);


            for(int j=1; j<=tspace; j++){
    System.out.print("   ");

            }
for(int k=1; k<=star; k++){
        System.out.print(" * ");
    }

            System.out.println();
        }


    }

}
