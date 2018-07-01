<template>
  <div id="app">

    <div class="container">
      <header id="site-header">
        <div class="row">
          <div class="col-md-4 col-sm-5 col-xs-8">
            <div class="logo">
              <h1>
                <router-link to="/">Murat Kuru</router-link>
              </h1>
            </div>
          </div>
          <!-- col-md-4 -->
          <div class="col-md-8 col-sm-7 col-xs-4">
            <nav class="main-nav" role="navigation">
              <div class="navbar-header">
                <button type="button" id="trigger-overlay" class="navbar-toggle">
                  <span class="ion-navicon"></span>
                </button>
              </div>

              <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                  <li class="cl-effect-11">
                    <router-link to="/">Home</router-link>
                  </li>
                  <li class="cl-effect-11">
                    <router-link to="/about">About</router-link>
                  </li>
                  <li class="cl-effect-11">
                    <router-link to="/contact">Contact</router-link>
                  </li>
                </ul>
              </div>
              <!-- /.navbar-collapse -->
            </nav>
            <div id="header-search-box">
              <a id="search-menu" href="#">
                <span id="search-icon" class="ion-ios-search-strong"></span>
              </a>
              <div id="search-form" class="search-form">
                <form role="search" method="get" id="searchform" action="#">
                  <input type="search" placeholder="Search" required>
                  <button type="submit">
                    <span class="ion-ios-search-strong"></span>
                  </button>
                </form>
              </div>
            </div>
          </div>
          <!-- col-md-8 -->
        </div>
      </header>
    </div>
    <div class="content-body">
      <div class="container">
        <div class="row">
            <router-view></router-view>
        </div>
      </div>
    </div>
    <footer id="site-footer">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <p class="copyright">&copy; 2014 ThemeWagon.com</p>
          </div>
        </div>
      </div>
    </footer>

    <!-- Mobile Menu -->
    <div class="overlay overlay-hugeinc">
      <button type="button" class="overlay-close">
        <span class="ion-ios-close-empty"></span>
      </button>
      <nav>
        <ul>
          <li>
            <a href="index.html">Home</a>
          </li>
          <li>
            <a href="full-width.html">Blog</a>
          </li>
          <li>
            <a href="about.html">About</a>
          </li>
          <li>
            <a href="contact.html">Contact</a>
          </li>
        </ul>
      </nav>
    </div>


  </div>
</template>

<script>

  export default {
    name: 'app'
  }
  
</script>

<style>
</style>