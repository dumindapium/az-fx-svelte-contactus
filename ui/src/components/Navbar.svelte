<script>
    import { Link } from "svelte-navigator";


</script>

<nav class="bg-slate-200">
    <div class="mx-auto max-w-7xl px-2 sm:px-6 lg:px-8">
      <div class="relative flex h-16 items-center justify-between">
        
        <div class="flex flex-1 items-center justify-center sm:items-stretch sm:justify-start">
          <div class="flex flex-shrink-0 items-center">
            <img class="h-8 w-auto" src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=500" alt="Your Company">
          </div>
          <div class="hidden sm:ml-6 sm:block">
            <div class="flex space-x-4">
              <Link to="/" class="bg-gray-500 text-white rounded-md px-3 py-2 text-sm font-medium" aria-current="page" >Home</Link>          
              <Link to="contact" class="text-gray-500 hover:bg-gray-700 hover:text-white rounded-md px-3 py-2 text-sm font-medium">Contact</Link>
              
            </div>
          </div>
        </div>
      </div>
    </div>
  
    <!-- Mobile menu, show/hide based on menu state. -->
    <div class="sm:hidden" id="mobile-menu">
      <div class="space-y-1 px-2 pb-3 pt-2">
        <Link to="/" class="bg-gray-500 text-white rounded-md px-3 py-2 text-sm font-medium" aria-current="page" >Home</Link>          
        <Link to="contact" class="text-gray-500 hover:bg-gray-700 hover:text-white rounded-md px-3 py-2 text-sm font-medium">Contact</Link>
        
      </div>
    </div>
  </nav>
  
