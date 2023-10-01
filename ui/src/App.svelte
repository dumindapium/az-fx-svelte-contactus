<script>
  import Navbar from "./components/Navbar.svelte";
  import { Router, Link, Route } from "svelte-navigator";
	import Home from "./routes/Home.svelte";
	import Contact from "./routes/Contact.svelte";
</script>




<Router>
	<Navbar />
	<div class="mx-auto max-w-7xl py-6 sm:px-6 lg:px-8">
		<Route path="/">
			<Home />
		</Route>
		<Route path="contact" component={Contact} />
	</div>
</Router>

<style lang="postcss">
  :global(html) {
    background-color: theme(colors.gray.50);
  }
</style>