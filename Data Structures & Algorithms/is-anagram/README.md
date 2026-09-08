Common Approach:
int[] count = new int[26];

Optimized Approach:
Span<int> counts = stackalloc int[26]; //26 × 4 = 104 bytes
//104 bytes are reserved in the current method's stack frame.
stackalloc means allocate memory on the stack instead of the heap.

Note: 
1. stackalloc produces stack memory, so you typically store it in a Span<T>.
2. Span<T> is like a lightweight view over memory.

Advantages (Span<int> counts = stackalloc int[26]):
1. Memory is allocated on the stack.
2. Automatically disappears when the method returns.
3. No GC involvement.
4. Faster for small, fixed-size arrays.

Pseudo Code: 
FUNCTION IsAnagram(s, t)
    IF length(s) != length(t)
        RETURN false
    counts = array of size 26 filled with 0
    FOR EACH character ch IN s
        counts[ch - 'a']++
    FOR EACH character ch IN t
        counts[ch - 'a']--
        IF counts[ch - 'a'] < 0
            RETURN false
    RETURN true
