using System.Runtime.CompilerServices;
using Leopotam.EcsLite;

namespace Kk.XLiteFilters
{
    public abstract class PoolSet
    {
        internal PoolSet() {}
    }
    
    public class PoolSet<T1> : PoolSet
            where T1 : struct
    {
        internal readonly EcsPool<T1> pool1;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2> : PoolSet
            where T1 : struct
            where T2 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2, T3> : PoolSet
            where T1 : struct
            where T2 : struct
            where T3 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2, T3, T4> : PoolSet
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;
        internal readonly EcsPool<T4> pool4;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
            pool4 = world.GetPool<T4>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Get4(int entity)
        {
            return ref pool4.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Add4(int entity)
        {
            return ref pool4.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has4(int entity)
        {
            return pool4.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del4(int entity)
        {
            pool4.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2, T3, T4, T5> : PoolSet
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;
        internal readonly EcsPool<T4> pool4;
        internal readonly EcsPool<T5> pool5;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
            pool4 = world.GetPool<T4>();
            pool5 = world.GetPool<T5>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Get4(int entity)
        {
            return ref pool4.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Add4(int entity)
        {
            return ref pool4.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has4(int entity)
        {
            return pool4.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del4(int entity)
        {
            pool4.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T5 Get5(int entity)
        {
            return ref pool5.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T5 Add5(int entity)
        {
            return ref pool5.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has5(int entity)
        {
            return pool5.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del5(int entity)
        {
            pool5.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2, T3, T4, T5, T6> : PoolSet
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;
        internal readonly EcsPool<T4> pool4;
        internal readonly EcsPool<T5> pool5;
        internal readonly EcsPool<T6> pool6;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
            pool4 = world.GetPool<T4>();
            pool5 = world.GetPool<T5>();
            pool6 = world.GetPool<T6>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Get4(int entity)
        {
            return ref pool4.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Add4(int entity)
        {
            return ref pool4.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has4(int entity)
        {
            return pool4.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del4(int entity)
        {
            pool4.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T5 Get5(int entity)
        {
            return ref pool5.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T5 Add5(int entity)
        {
            return ref pool5.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has5(int entity)
        {
            return pool5.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del5(int entity)
        {
            pool5.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T6 Get6(int entity)
        {
            return ref pool6.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T6 Add6(int entity)
        {
            return ref pool6.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has6(int entity)
        {
            return pool6.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del6(int entity)
        {
            pool6.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2, T3, T4, T5, T6, T7> : PoolSet
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
            where T7 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;
        internal readonly EcsPool<T4> pool4;
        internal readonly EcsPool<T5> pool5;
        internal readonly EcsPool<T6> pool6;
        internal readonly EcsPool<T7> pool7;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
            pool4 = world.GetPool<T4>();
            pool5 = world.GetPool<T5>();
            pool6 = world.GetPool<T6>();
            pool7 = world.GetPool<T7>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Get4(int entity)
        {
            return ref pool4.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Add4(int entity)
        {
            return ref pool4.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has4(int entity)
        {
            return pool4.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del4(int entity)
        {
            pool4.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T5 Get5(int entity)
        {
            return ref pool5.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T5 Add5(int entity)
        {
            return ref pool5.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has5(int entity)
        {
            return pool5.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del5(int entity)
        {
            pool5.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T6 Get6(int entity)
        {
            return ref pool6.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T6 Add6(int entity)
        {
            return ref pool6.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has6(int entity)
        {
            return pool6.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del6(int entity)
        {
            pool6.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T7 Get7(int entity)
        {
            return ref pool7.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T7 Add7(int entity)
        {
            return ref pool7.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has7(int entity)
        {
            return pool7.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del7(int entity)
        {
            pool7.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2, T3, T4, T5, T6, T7, T8> : PoolSet
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
            where T7 : struct
            where T8 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;
        internal readonly EcsPool<T4> pool4;
        internal readonly EcsPool<T5> pool5;
        internal readonly EcsPool<T6> pool6;
        internal readonly EcsPool<T7> pool7;
        internal readonly EcsPool<T8> pool8;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
            pool4 = world.GetPool<T4>();
            pool5 = world.GetPool<T5>();
            pool6 = world.GetPool<T6>();
            pool7 = world.GetPool<T7>();
            pool8 = world.GetPool<T8>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Get4(int entity)
        {
            return ref pool4.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Add4(int entity)
        {
            return ref pool4.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has4(int entity)
        {
            return pool4.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del4(int entity)
        {
            pool4.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T5 Get5(int entity)
        {
            return ref pool5.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T5 Add5(int entity)
        {
            return ref pool5.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has5(int entity)
        {
            return pool5.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del5(int entity)
        {
            pool5.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T6 Get6(int entity)
        {
            return ref pool6.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T6 Add6(int entity)
        {
            return ref pool6.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has6(int entity)
        {
            return pool6.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del6(int entity)
        {
            pool6.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T7 Get7(int entity)
        {
            return ref pool7.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T7 Add7(int entity)
        {
            return ref pool7.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has7(int entity)
        {
            return pool7.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del7(int entity)
        {
            pool7.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T8 Get8(int entity)
        {
            return ref pool8.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T8 Add8(int entity)
        {
            return ref pool8.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has8(int entity)
        {
            return pool8.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del8(int entity)
        {
            pool8.Del(entity);
        }
        
    }
}