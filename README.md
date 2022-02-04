# About

Extension for [LeoECS Lite](https://github.com/Leopotam/ecslite) for a [LeoECS Classic](https://github.com/Leopotam/ecs)-style filters.

# How to use

### Setup
```c#
EcsSystems ecsSystems = ...;
...
ecsSystems.Add(new MySystem1())
    
// should be invoked after systems registration, but before Init invocation
ecsSystems.InitXLiteFilters();

ecsSystems.Init();

```

### Filters 
Do not define pools to access components from filter
```c#

    // injected as in classic
    private TypedFilter<A, B> _anb = default;

    public void Run(EcsSystems systems)
    {
        foreach (int entity in _anb)
        {
            // as in ecs-classic
            ref A a = ref _anb.Get1(entity);
            ref B b = ref _anb.Get2(entity);
        }
    }
```

### Pool sets
Do not define each individual pool to access components outside of filter
```c#

private TypedFilter<A, B> _anb = default;

// injected as in classic too
private PoolSet<C, D> _cnd = default;

public void Run(EcsSystems systems)
{
    foreach (int entity in _anb)
    {
        // check if C present use positional access as in ecs-classic filters
        if (!_cnd.Has1(entity))
        {
            _cnd.Add1(entity) = new C();
        }
    }
}
```

### Multi-world
use attribute to specify world name. attribute is optional - default world used if it's absent. Note that worlds should still be configured as described in ecs-lite docs.
```c#

[WorldName("extraWorld")]
private TypedFilter<A, B> _anb;

[WorldName("extraWorld")]
private PoolSet<C, D> _cnd;
```