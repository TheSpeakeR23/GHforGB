package HW.HW_4;

import java.util.LinkedList;

public class Task1 {
    public static void main(String[] args) {

        int[] listMas = {10,23,4,9,4,34,565,1235};
        LinkedList<Integer> linkList = new LinkedList<>();

        for (Integer temp : listMas) {
            linkList.add(temp);
        }
        
        int temp = 0;
        while (temp != linkList.size() - 1) {
            linkList.add(linkList.size()-temp, linkList.getFirst());
            linkList.removeFirst();
            temp++;
        }


        System.out.println("linkList = " + linkList);

        
    }
}