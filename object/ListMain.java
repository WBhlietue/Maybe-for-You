public class ListMain {
    
    public static void main(String[] args) {
        LinearList list = new LinearList(new int[] { 1, 1, 2, 3, 6, 5, 4, 4, 10, 6, 5, 89, 5, 3 });
        System.out.println(list);
        System.out.println(list.Max());
        System.out.println(list.Min());
        System.out.println(list.Sum());
        System.out.println(list.Avarage());
        list.Sort();
        System.out.println(list);
        list.RemoveOdd();
        System.out.println(list);
        System.out.println(list.Max());
        System.out.println(list.Min());
        System.out.println(list.Sum());
        System.out.println(list.Avarage());
        list.Add(12);
        list.Add(1);
        System.out.println(list);
        System.out.println(list.Max());
        System.out.println(list.Min());
        System.out.println(list.Sum());
        System.out.println(list.Avarage());
    }
}
