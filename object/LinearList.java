import java.util.*;

public class LinearList {
    List<Integer> list = new ArrayList<Integer>();
    private int max, min, sum;

    public LinearList() {
        sum = 0;
    }

    public LinearList(int[] nums) {
        sum = 0;
        for (int i : nums) {
            Add(i);
        }
    }

    public void Add(int num) {
        list.add(num);
        sum += num;
        if (list.size() == 1) {
            max = num;
            min = num;
        } else {
            if (max < num) {
                max = num;
            }
            if (min > num) {
                min = num;
            }
        }
    }

    public int Get(int i) {
        return list.get(i);
    }

    void Calc() {
        min = list.get(0);
        max = list.get(0);
        sum = 0;
        for (int i = 1; i < list.size(); i++) {
            if (min > list.get(i)) {
                min = list.get(i);
            }
            if (max < list.get(i)) {
                max = list.get(i);
            }
            sum += list.get(i);
        }
    }

    public LinearList Reverse() {
        LinearList arr = new LinearList();
        for (int i = list.size() - 1; i >= 0; i--) {
            arr.Add(list.get(i));
        }
        return arr;
    }

    public int Max() {
        return max;
    }

    public int Min() {
        return min;
    }

    public int Sum() {
        return sum;
    }

    public double Avarage() {
        return (double) sum / (double) list.size();
    }

    public LinearList RemoveOdd() {
        LinearList l = new LinearList();
        for (int i = 0; i < list.size(); i++) {
            if (list.get(i) % 2 == 1) {
                l.Add(list.get(i));
                list.remove(i);
                i--;
            }
        }
        Calc();
        return l;
    }

    public void Sort() {
        int j;
        List<Integer> arr = new ArrayList<Integer>();
        for (int i = 0; i < list.size(); i++) {
            for (j = 0; j < arr.size(); j++) {
                if (list.get(i) < arr.get(j)) {
                    break;
                }
            }
            arr.add(j, list.get(i));
        }
        list = arr;
    }

    @Override
    public String toString() {
        String str = "[";
        for (int i = 0; i < list.size(); i++) {
            str += list.get(i);
            str += ", ";
        }
        str = str.substring(0, str.length() - 2);
        str += "]";
        return str;
    }
}
