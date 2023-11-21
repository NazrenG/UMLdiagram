// factory method 

namespace FactoryMethod
{
    public interface Product
    {
        public void doStuff();
    }

    public class ConcreteProductA : Product
    {
        public void doStuff()
        {
            throw new NotImplementedException();
        }
    }

    public class ConcreteProductB : Product
    {
        public void doStuff()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Creator
    {
        public void someOperation()
        {
            Product p = createProduct();
            p.doStuff();
        }
        public Product createProduct() { throw new NotImplementedException(); }

    }

    public class ConcreteCreatorA : Creator
    {
        public Product createProduct()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public Product createProduct()
        {
            return new ConcreteProductB();
        }
    }
}



//Proxy
namespace ProxyMethod
{
    public interface ServiceInterface
    {
        public void operation();
    }

    public class Service : ServiceInterface
    {
        public void operation()
        {
            //do work
        }
    }

    public class Proxy : ServiceInterface
    {
        private Service realServices;

        public Proxy(Service realservices) { this.realServices = realservices; }

        public bool checkAccess() { throw new NotImplementedException(); }
        public void operation()
        {
            if (checkAccess())
            {
                realServices.operation();
            }
        }
    }

    public class Client
    {
        ServiceInterface realServices;

        public Client(ServiceInterface realServices)
        {
            this.realServices = realServices;
        }
    }
}

//Mediator
public interface Mediator
{
    public void notify(object? sender);
}
public class ComponentA
{
    private Mediator? m;
    public void operationA()
    {
        m.notify(this);
    }
}

public class ComponentB
{
    private Mediator? m;
    public void operationB()
    {
        m.notify(this);
    }
}

public class ComponentC
{
    private Mediator? m;
    public void operationC()
    {
        m.notify(this);
    }
}

public class ComponentD
{
    private Mediator? m;
    public void operationD()
    {
        m.notify(this);
    }
}

public abstract class ConcreteMediator : Mediator
{
    private ComponentA? componentA;
    private ComponentB? componentB;
    private ComponentC? componentC;
    private ComponentD? componentD;

    public void reactOnA()
    { //do work
    }
    public void reactOnB()
    { //do work
    }
    public void reactOnC()
    { //do work
    }
    public void reactOnD()
    { //do work
    }

    public void notify(object? sender)
    {
        if (sender == componentA)
            reactOnA();
        else if (sender == componentB)
            reactOnB();
        else if (sender == componentC)
            reactOnC();
        else if (sender == componentD)
            reactOnD();
    }
}
