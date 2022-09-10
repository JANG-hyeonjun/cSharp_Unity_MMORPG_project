using System;
using System.Collections.Generic;

namespace Lambda
{
    //어떤 가상의 인벤토리 시스템을 만든다고 가정 
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }
    
    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType itemtype;
        public Rarity rarity;
    }

    class Program
    {
        static List<Item> _itmes = new List<Item>();
        
        //이러한 상황에서 내가 가진 아이템중에 희귀한것을 찾고 싶다. 또는 무기를 찾고 싶다.

        //static Item FindWeapon()
        //{
        //    foreach(Item item in _itmes)
        //    {
        //        if (item.itemtype == ItemType.Weapon)
        //            return item;
        //    }
        //    return null;
        //}

        //static Item FindRareItem()
        //{
        //    foreach (Item item in _itmes)
        //    {
        //        if (item.rarity== Rarity.Rare)
        //            return item;
        //    }
        //    return null;
        //}
        //이렇게 하면 너무 힘드니까
        
        //Delegate 사용
        delegate bool ItemSelector (Item item); //인자로 넘길수 있는 형식이자 타입

        //추가적으로 Delegate에 generic을 사용할 수도 있다.
        delegate Return MyFunc<Return>();
        delegate Return MyFunc<T, Return>(T item);
        delegate Return MyFunc<T1,T2, Return>(T1 t1,T2 t2);
        //이거 하나로 반환 형식 하나 입력형식 하나있는 타입의 delegate 는 MyFunc를 이용해 넘길수 있다.

        //위와 같은건 이미 CSharp에서 default로 설정 되어 있다.
        //즉 delegate를 직접 선언하지 않아도 이미 만들어진 애들이 존재하며 
        //Func -> 반환타입이 있을 경우
        //Action -> 반환 타입이 없을 경우

        static Item FindItem(/*MyFunc<Item,bool>*/Func<Item, bool> selector)
        {
            foreach (Item item in _itmes)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        //그러면 결국함수를 계속 만들어야 하는 반복적인일은 계속 반복된다.
        //static bool isWeapon(Item item)
        //{
        //    return item.itemtype == ItemType.Weapon;
        //}

        static void Main(string[] args)
        {
            //Lambda : 일회용 함수를 만드는데 사용하는 문법이다.
            _itmes.Add(new Item() { itemtype = ItemType.Weapon, rarity = Rarity.Normal});
            _itmes.Add(new Item() { itemtype = ItemType.Armor, rarity = Rarity.Uncommon });
            _itmes.Add(new Item() { itemtype = ItemType.Ring, rarity = Rarity.Rare });

            //Item item = FindItem(isWeapon);

            //이러한 방법이 람다 문법을 이용한것은 아니다. 그냥 무명함수 익명함수를 사용했다고 함
            //Anonymous Function
            //Item item = FindItem(delegate (Item item) { return item.itemtype == ItemType.Weapon;});
            
            //람다식
            Item item = FindItem((Item item) => { return item.itemtype == ItemType.Weapon; });

            //그리고 1회성 이라는것에 주목하면 안되는것이 Delegate 객체를 초기화 할떄도 사용가능하다.

            Func<Item, bool> selector =  (Item item) => { return item.itemtype == ItemType.Weapon; };
            item = FindItem(selector);
        }
    }
}
