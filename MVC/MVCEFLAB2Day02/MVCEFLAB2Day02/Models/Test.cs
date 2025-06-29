namespace MVCEFLAB2Day02.Models
{
    public interface Isort
    {
        void sort(int[]arr);
    }
    public class bubblesort : Isort
    {
        public void sort(int[] arr)
        {
            //logic 
        }

       
    }
    public class moomensort : Isort
    {
        public void sort(int[] arr)
        {
            throw new NotImplementedException();
        }
    }
    public class selectsort : Isort
    {
        public void sort(int[] arr)
        {
            throw new NotImplementedException();
        }
    }
    public class Mylist
    {
        int[] arr;
        Isort  sortintmode;
        public Mylist( Isort _sortingmode)
        {
            arr = new int[10];
            sortintmode = _sortingmode;

        }
        public void sort() { 
        sortintmode.sort(arr);
        }
    }
    public class Mycontroller
    {

        public void controller() {

            Mylist list = new Mylist(new selectsort());
            list.sort();
            Mylist l2 = new Mylist(new moomensort());
            l2.sort();
        }
        
    }

}
