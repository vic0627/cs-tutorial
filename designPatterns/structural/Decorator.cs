namespace DesignPatterns.Structural.Decorator;

/*
    The base Component interface defines operations that can be altered by decorators.
    基礎組件介面定義了可以被裝飾器改變的方法。
 */
public abstract class Component
{
    public abstract string Operation();
}

/*
    Concrete Components provide default implementations of the operations.
    實體組件提供基礎組件方法的實現。
    There might be several variations of these classes.
    可能會存在多個不同的實體組件。
 */
class ConcreteComponent : Component
{
    public override string Operation()
    {
        return "ConcreteComponent";
    }
}

/*
    The base Decorator class follows the same interface as the other components.
    基礎裝飾器類別與其他組件會遵循相同的介面。
    The primary purpose of this class is to define the wrapping interface for all cencrete decorators.
    這個類別主要的目的是定義所有實體裝飾器的包裝介面。
    The default implementation of the wrapping code might include a field for string a wrapped component and the means to initialize it.
    包裝程式的默認實作可能包含了一個用於包裝組件的字串欄位以及初始化該欄位的方法。
 */
abstract class Decorator : Component
{
    protected Component _component;

    public Decorator(Component component)
    {
        _component = component;
    }

    public void SetComponent(Component component)
    {
        _component = component;
    }

    /*
        The Decorator delegates all work to the wrapped component.
        裝飾器將所有的工作委派給包裝組件。
     */
    public override string Operation()
    {
        if (_component != null)
        {
            return _component.Operation();
        }
        else
        {
            return string.Empty;
        }
    }
}

/*
    Concrete Decorators call the wrapped object and alter its result in some way.
    實體裝飾器呼叫被包裹的物件，並以某種方式修改其結果。

 */
class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component comp)
        : base(comp) { }

    /*
        Decorators may call parent implementation of the operation, instead of calling the wrapped object directly.
        裝飾器可以調用操作的父類實現，而不是直接調用被包裹的對象。
        This approach simplifies extension of decorator classes.
        這方法簡化了裝飾器類別的擴展。
     */
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}

/*
    Decorators can execute their behavior either before or after the call to a wrapped object.
    裝飾器可以在對包裹對象的調用之前或之後執行它們的行為。
 */
class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(Component comp)
        : base(comp) { }

    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}

public class Client
{
    public void Result(Component component)
    {
        Console.WriteLine("Result: " + component.Operation());
    }
}

public class Execute
{
    public static void Exe()
    {
        Client client = new();

        ConcreteComponent simple = new();
        Console.WriteLine("Client: I get a simple component:");
        client.Result(simple);
        Console.WriteLine();

        /*
            Note how decorators can wrap not only simple comopnents but the other decorators as well.
            要知道裝飾器不只可以使用在基礎組件上，也可以使用在其它裝飾器上。
         */
        ConcreteDecoratorA decoratorA = new(simple);
        ConcreteDecoratorB decoratorB = new(decoratorA);
        Console.WriteLine("Client: Now I've got a decorated component:");
        client.Result(decoratorB);
    }
}
