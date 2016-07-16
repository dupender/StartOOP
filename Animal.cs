namespace Zoo
{
    public class Animal{
        public string sleep(){ //this is a method/behavior
            return "Zzzzz";
        }
        virtual public string dance(){
            //"virtual" allows behaviors to be redefined (i.e. by override) by children
            return null; //"null" can serve as a do-nothing place holder for any type
        }

        private string respiration(){  //Children cannot use
            return "breath!";
        }

        protected string swim(){ //Similar to a family secret, children have access
            return "Swoosh";
        }
    }
    public class Dog : Animal { //How to inherit behavior from Animal (See the ":")
        override public string dance(){
            return "Rag-Top Don't Stop....Rag-Top don't stop ...";
        }
    }

    public class Cat : Animal {
        //Ad-Hoc Polymorphism same method, different argument types.
        public string meow() {
            return "Meow!";
        }

        private string purr() { //Private methods can only be used from within a class.
        //this.respriation () cannot be accessed here;
            return "purr!";
        }

        public string meowThenPurr(){
            return this.meow() + " " + this.purr();
        }

        public string meow(int number_of_pets){ //We've OVERLOADED the "meow" method
            if (number_of_pets <= 0){
                return this.meow(); //"this" means the current instance (or scope or class) of Cat
            }else {
            return "meow! You've pet me!";
            }
        }
    }
}