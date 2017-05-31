using System;

namespace Inheritance_Interface
{
    class RoomSize
    {

        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;

        }

        protected int width;
        protected int height;


    }

    public interface PaperCost
    {
        int getPrice(int area);
    }

    class Room : RoomSize, PaperCost
    {
        public int getArea()
        {
            return (width * height);

        }
        public int getPrice(int area)
        {

            return area * 90;
        }
    }
    class PriceTester
    {

        static void Main(string[] args)
        {
            Room room = new Room();
            int price;
            room.setHeight(200);
            room.setWidth(67);
            price = room.getArea();

            Console.WriteLine("Cost: € {0}", price);
        }

    }

}