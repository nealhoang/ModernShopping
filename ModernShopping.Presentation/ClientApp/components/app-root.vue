<template>
    <div id="app" class="container bg-light">
        <notifications group="general-message"/>
        <nav-menu/>
        <div class="row app-body pt-4 pb-4">
            <div class="col">
                <transition enter-active-class="animated slideInUp" mode="out-in">
                    <router-view></router-view>
                </transition>
            </div>
        </div>
    </div>
</template>

<script>
import NavMenu from './nav-menu'

export default {
    components: {
        'nav-menu': NavMenu
    },

    data() {
        return {}
    }
}
</script>
