string[] firstName = {"Fred","Aubrey","Alexla","Benjamin","Kermit","Johnathan","Luke","Tanner","Ash","Sans"};
string[] middleName = {"Joe Billy","Rolland","Ridge","Tari","The","Vernal","E","James","catch",""};
string[] lastName = {"Bob III","Seamons","Wakefeild","Johnson","Frog","em'","Cena","Bowns","Miller","Undertale"};
string[] job = {"Little Ceaser's","Jimmy Johns","Walmart"};
double[] wage = {7.50,9.00,10.00,12.00,14.00,};
string[] salery = {"well mabey not"};
int oneOrTwo = 2;


int a = 1;
int l = -1;
int m = -1;
if (oneOrTwo == 2){
    for(int i = 0; i < 10; i++){
        //first name
        for(int j = 0; j < 10; j++){
            //Middle name
            for(int k = 0; k < 10; k++){
                //Last name
                l = l + 1;
                if (l>2){
                    l=0;
                }
                m++;
                if(m>4){
                    m=0;
                }
                Console.WriteLine($"{a++}: {firstName[i]} {middleName[j]} {lastName[k]} works at {job[l]} with a pay of ${wage[m]} an hour, their salery is ${wage[m]*40*50} a year");
            }
        }
    }
}

