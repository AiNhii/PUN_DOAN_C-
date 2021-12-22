! function(a) {
    function b(b, d) {
        function e() {
            if (w) {
                $canvas = a('<canvas class="pg-canvas"></canvas>'), v.prepend($canvas), p = $canvas[0], q = p.getContext("2d"), f();
                for (var b = Math.round(p.width * p.height / d.density), c = 0; b > c; c++) {
                    var e = new l;
                    e.setStackPos(c), x.push(e)
                }
                a(window).on("resize", function() {
                    h()
                }), a(document).on("mousemove", function(a) {
                    y = a.pageX, z = a.pageY
                }), B && !A && window.addEventListener("deviceorientation", function() {
                    D = Math.min(Math.max(-event.beta, -30), 30), C = Math.min(Math.max(-event.gamma, -30), 30)
                }, !0), g(), o("onInit")
            }
        }

        function f() {
            p.width = v.width(), p.height = v.height(), q.fillStyle = d.dotColor, q.strokeStyle = d.lineColor, q.lineWidth = d.lineWidth
        }

        function g() {
            if (w) {
                s = a(window).width(), t = a(window).height(), q.clearRect(0, 0, p.width, p.height);
                for (var b = 0; b < x.length; b++) x[b].updatePosition();
                for (var b = 0; b < x.length; b++) x[b].draw();
                E || (r = requestAnimationFrame(g))
            }
        }

        function h() {
            for (f(), i = x.length - 1; i >= 0; i--)(x[i].position.x > v.width() || x[i].position.y > v.height()) && x.splice(i, 1);
            var a = Math.round(p.width * p.height / d.density);
            if (a > x.length)
                for (; a > x.length;) {
                    var b = new l;
                    x.push(b)
                } else a < x.length && x.splice(a);
            for (i = x.length - 1; i >= 0; i--) x[i].setStackPos(i)
        }

        function j() {
            E = !0
        }

        function k() {
            E = !1, g()
        }

        function l() {
            switch (this.stackPos, this.active = !0, this.layer = Math.ceil(3 * Math.random()), this.parallaxOffsetX = 0, this.parallaxOffsetY = 0, this.position = {
                x: Math.ceil(Math.random() * p.width),
                y: Math.ceil(Math.random() * p.height)
            }, this.speed = {}, d.directionX) {
                case "left":
                    this.speed.x = +(-d.maxSpeedX + Math.random() * d.maxSpeedX - d.minSpeedX).toFixed(2);
                    break;
                case "right":
                    this.speed.x = +(Math.random() * d.maxSpeedX + d.minSpeedX).toFixed(2);
                    break;
                default:
                    this.speed.x = +(-d.maxSpeedX / 2 + Math.random() * d.maxSpeedX).toFixed(2), this.speed.x += this.speed.x > 0 ? d.minSpeedX : -d.minSpeedX
            }
            switch (d.directionY) {
                case "up":
                    this.speed.y = +(-d.maxSpeedY + Math.random() * d.maxSpeedY - d.minSpeedY).toFixed(2);
                    break;
                case "down":
                    this.speed.y = +(Math.random() * d.maxSpeedY + d.minSpeedY).toFixed(2);
                    break;
                default:
                    this.speed.y = +(-d.maxSpeedY / 2 + Math.random() * d.maxSpeedY).toFixed(2), this.speed.x += this.speed.y > 0 ? d.minSpeedY : -d.minSpeedY
            }
        }

        function m(a, b) {
            return b ? void(d[a] = b) : d[a]
        }

        function n() {
            v.find(".pg-canvas").remove(), o("onDestroy"), v.removeData("plugin_" + c)
        }

        function o(a) {
            void 0 !== d[a] && d[a].call(u)
        }
        var p, q, r, s, t, u = b,
            v = a(b),
            w = !!document.createElement("canvas").getContext,
            x = [],
            y = 0,
            z = 0,
            A = !navigator.userAgent.match(/(iPhone|iPod|iPad|Android|BlackBerry|BB10|mobi|tablet|opera mini|nexus 7)/i),
            B = !!window.DeviceOrientationEvent,
            C = 0,
            D = 0,
            E = !1;
        return d = a.extend({}, a.fn[c].defaults, d), l.prototype.draw = function() {
            q.beginPath(), q.arc(this.position.x + this.parallaxOffsetX, this.position.y + this.parallaxOffsetY, d.particleRadius / 2, 0, 2 * Math.PI, !0), q.closePath(), q.fill(), q.beginPath();
            for (var a = x.length - 1; a > this.stackPos; a--) {
                var b = x[a],
                    c = this.position.x - b.position.x,
                    e = this.position.y - b.position.y,
                    f = Math.sqrt(c * c + e * e).toFixed(2);
                f < d.proximity && (q.moveTo(this.position.x + this.parallaxOffsetX, this.position.y + this.parallaxOffsetY), d.curvedLines ? q.quadraticCurveTo(Math.max(b.position.x, b.position.x), Math.min(b.position.y, b.position.y), b.position.x + b.parallaxOffsetX, b.position.y + b.parallaxOffsetY) : q.lineTo(b.position.x + b.parallaxOffsetX, b.position.y + b.parallaxOffsetY))
            }
            q.stroke(), q.closePath()
        }, l.prototype.updatePosition = function() {
            if (d.parallax) {
                if (B && !A) {
                    var a = (s - 0) / 60;
                    pointerX = (C - -30) * a + 0;
                    var b = (t - 0) / 60;
                    pointerY = (D - -30) * b + 0
                } else pointerX = y, pointerY = z;
                this.parallaxTargX = (pointerX - s / 2) / (d.parallaxMultiplier * this.layer), this.parallaxOffsetX += (this.parallaxTargX - this.parallaxOffsetX) / 10, this.parallaxTargY = (pointerY - t / 2) / (d.parallaxMultiplier * this.layer), this.parallaxOffsetY += (this.parallaxTargY - this.parallaxOffsetY) / 10
            }
            switch (d.directionX) {
                case "left":
                    this.position.x + this.speed.x + this.parallaxOffsetX < 0 && (this.position.x = v.width() - this.parallaxOffsetX);
                    break;
                case "right":
                    this.position.x + this.speed.x + this.parallaxOffsetX > v.width() && (this.position.x = 0 - this.parallaxOffsetX);
                    break;
                default:
                    (this.position.x + this.speed.x + this.parallaxOffsetX > v.width() || this.position.x + this.speed.x + this.parallaxOffsetX < 0) && (this.speed.x = -this.speed.x)
            }
            switch (d.directionY) {
                case "up":
                    this.position.y + this.speed.y + this.parallaxOffsetY < 0 && (this.position.y = v.height() - this.parallaxOffsetY);
                    break;
                case "down":
                    this.position.y + this.speed.y + this.parallaxOffsetY > v.height() && (this.position.y = 0 - this.parallaxOffsetY);
                    break;
                default:
                    (this.position.y + this.speed.y + this.parallaxOffsetY > v.height() || this.position.y + this.speed.y + this.parallaxOffsetY < 0) && (this.speed.y = -this.speed.y)
            }
            this.position.x += this.speed.x, this.position.y += this.speed.y
        }, l.prototype.setStackPos = function(a) {
            this.stackPos = a
        }, e(), {
            option: m,
            destroy: n,
            start: k,
            pause: j
        }
    }
    var c = "particleground";
    a.fn[c] = function(d) {
        if ("string" == typeof arguments[0]) {
            var e, f = arguments[0],
                g = Array.prototype.slice.call(arguments, 1);
            return this.each(function() {
                a.data(this, "plugin_" + c) && "function" == typeof a.data(this, "plugin_" + c)[f] && (e = a.data(this, "plugin_" + c)[f].apply(this, g))
            }), void 0 !== e ? e : this
        }
        return "object" != typeof d && d ? void 0 : this.each(function() {
            a.data(this, "plugin_" + c) || a.data(this, "plugin_" + c, new b(this, d))
        })
    }, a.fn[c].defaults = {
        minSpeedX: .1,
        maxSpeedX: .7,
        minSpeedY: .1,
        maxSpeedY: .7,
        directionX: "center",
        directionY: "center",
        density: 1e4,
        dotColor: "#666666",
        lineColor: "#666666",
        particleRadius: 7,
        lineWidth: 1,
        curvedLines: !1,
        proximity: 100,
        parallax: !0,
        parallaxMultiplier: 5,
        onInit: function() {},
        onDestroy: function() {}
    }
}(jQuery),
/**
 * requestAnimationFrame polyfill by Erik Möller. fixes from Paul Irish and Tino Zijdel
 * @see: http://paulirish.com/2011/requestanimationframe-for-smart-animating/
 * @see: http://my.opera.com/emoller/blog/2011/12/20/requestanimationframe-for-smart-er-animating
 * @license: MIT license
 */
function() {
    for (var a = 0, b = ["ms", "moz", "webkit", "o"], c = 0; c < b.length && !window.requestAnimationFrame; ++c) window.requestAnimationFrame = window[b[c] + "RequestAnimationFrame"], window.cancelAnimationFrame = window[b[c] + "CancelAnimationFrame"] || window[b[c] + "CancelRequestAnimationFrame"];
    window.requestAnimationFrame || (window.requestAnimationFrame = function(b) {
        var c = (new Date).getTime(),
            d = Math.max(0, 16 - (c - a)),
            e = window.setTimeout(function() {
                b(c + d)
            }, d);
        return a = c + d, e
    }), window.cancelAnimationFrame || (window.cancelAnimationFrame = function(a) {
        clearTimeout(a)
    })
}();

$(function() {

    $('#particles').particleground({
        minSpeedX: 0.1,
        maxSpeedX: 0.7,
        minSpeedY: 0.1,
        maxSpeedY: 0.7,
        directionX: 'center', // 'center', 'left' or 'right'. 'center' = dots bounce off edges
        directionY: 'center', // 'center', 'up' or 'down'. 'center' = dots bounce off edges
        density: 10000, // How many particles will be generated: one particle every n pixels
        dotColor: '#eee',
        lineColor: '#eee',
        particleRadius: 7, // Dot size
        lineWidth: 1,
        curvedLines: true,
        proximity: 100, // How close two dots need to be before they join
        parallax: false
    });

});





/*panel*/



function htmlbodyHeightUpdate() {
    var height3 = $(window).height()
    var height1 = $('.nav').height() + 50
    height2 = $('.main').height()
    if (height2 > height3) {
        $('html').height(Math.max(height1, height3, height2) + 10);
        $('body').height(Math.max(height1, height3, height2) + 10);
    } else {
        $('html').height(Math.max(height1, height3, height2));
        $('body').height(Math.max(height1, height3, height2));
    }

}
$(document).ready(function() {
    htmlbodyHeightUpdate()
    $(window).resize(function() {
        htmlbodyHeightUpdate()
    });
    $(window).scroll(function() {
        height2 = $('.main').height()
        htmlbodyHeightUpdate()
    });
});



/*navbar*/
$(function() {
    /* START OF DEMO JS - NOT NEEDED */
    if (window.location == window.parent.location) {
        $('#fullscreen').html('<span class="glyphicon glyphicon-resize-small"></span>');
        $('#fullscreen').attr('href', 'http://bootsnipp.com/mouse0270/snippets/PbDb5');
        $('#fullscreen').attr('title', 'Back To Bootsnipp');
    }
    $('#fullscreen').on('click', function(event) {
        event.preventDefault();
        window.parent.location = $('#fullscreen').attr('href');
    });
    $('#fullscreen').tooltip();
    /* END DEMO OF JS */

    $('.navbar-toggler').on('click', function(event) {
        event.preventDefault();
        $(this).closest('.navbar-minimal').toggleClass('open');
    })
});

function htmlbodyHeightUpdate() {
    var height3 = $(window).height()
    var height1 = $('.nav').height() + 50
    height2 = $('.main').height()
    if (height2 > height3) {
        $('html').height(Math.max(height1, height3, height2) + 10);
        $('body').height(Math.max(height1, height3, height2) + 10);
    } else {
        $('html').height(Math.max(height1, height3, height2));
        $('body').height(Math.max(height1, height3, height2));
    }

}
$(document).ready(function() {
    htmlbodyHeightUpdate()
    $(window).resize(function() {
        htmlbodyHeightUpdate()
    });
    $(window).scroll(function() {
        height2 = $('.main').height()
        htmlbodyHeightUpdate()
    });
}); /*file khac*/
var searchVisible = 0;
var transparent = true;
var mobile_device = false;

$(document).ready(function() {

    $.material.init();

    /*  Activate the tooltips      */
    $('[rel="tooltip"]').tooltip();

    // Code for the Validator
    var $validator = $('.wizard-card form').validate({
        rules: {
            firstname: {
                required: true,
                minlength: 3
            },
            lastname: {
                required: true,
                minlength: 3
            },
            email: {
                required: true,
                minlength: 3,
            }
        },

        errorPlacement: function(error, element) {
            $(element).parent('div').addClass('has-error');
        }
    });

    // Wizard Initialization
    $('.wizard-card').bootstrapWizard({
        'tabClass': 'nav nav-pills',
        'nextSelector': '.btn-next',
        'previousSelector': '.btn-previous',

        onNext: function(tab, navigation, index) {
            var $valid = $('.wizard-card form').valid();
            if (!$valid) {
                $validator.focusInvalid();
                return false;
            }
        },

        onInit: function(tab, navigation, index) {
            //check number of tabs and fill the entire row
            var $total = navigation.find('li').length;
            var $wizard = navigation.closest('.wizard-card');

            $first_li = navigation.find('li:first-child a').html();
            $moving_div = $('<div class="moving-tab">' + $first_li + '</div>');
            $('.wizard-card .wizard-navigation').append($moving_div);

            refreshAnimation($wizard, index);

            $('.moving-tab').css('transition', 'transform 0s');
        },

        onTabClick: function(tab, navigation, index) {
            var $valid = $('.wizard-card form').valid();

            if (!$valid) {
                return false;
            } else {
                return true;
            }
        },

        onTabShow: function(tab, navigation, index) {
            var $total = navigation.find('li').length;
            var $current = index + 1;

            var $wizard = navigation.closest('.wizard-card');

            // If it's the last tab then hide the last button and show the finish instead
            if ($current >= $total) {
                $($wizard).find('.btn-next').hide();
                $($wizard).find('.btn-finish').show();
            } else {
                $($wizard).find('.btn-next').show();
                $($wizard).find('.btn-finish').hide();
            }

            button_text = navigation.find('li:nth-child(' + $current + ') a').html();

            setTimeout(function() {
                $('.moving-tab').text(button_text);
            }, 150);

            var checkbox = $('.footer-checkbox');

            if (!index == 0) {
                $(checkbox).css({
                    'opacity': '0',
                    'visibility': 'hidden',
                    'position': 'absolute'
                });
            } else {
                $(checkbox).css({
                    'opacity': '1',
                    'visibility': 'visible'
                });
            }

            refreshAnimation($wizard, index);
        }
    });


    // Prepare the preview for profile picture
    $("#wizard-picture").change(function() {
        readURL(this);
    });

    $('[data-toggle="wizard-radio"]').click(function() {
        wizard = $(this).closest('.wizard-card');
        wizard.find('[data-toggle="wizard-radio"]').removeClass('active');
        $(this).addClass('active');
        $(wizard).find('[type="radio"]').removeAttr('checked');
        $(this).find('[type="radio"]').attr('checked', 'true');
    });

    $('[data-toggle="wizard-checkbox"]').click(function() {
        if ($(this).hasClass('active')) {
            $(this).removeClass('active');
            $(this).find('[type="checkbox"]').removeAttr('checked');
        } else {
            $(this).addClass('active');
            $(this).find('[type="checkbox"]').attr('checked', 'true');
        }
    });

    $('.set-full-height').css('height', 'auto');

});



//Function to show image before upload

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function(e) {
            $('#wizardPicturePreview').attr('src', e.target.result).fadeIn('slow');
        }
        reader.readAsDataURL(input.files[0]);
    }
}

$(window).resize(function() {
    $('.wizard-card').each(function() {
        $wizard = $(this);

        index = $wizard.bootstrapWizard('currentIndex');
        refreshAnimation($wizard, index);

        $('.moving-tab').css({
            'transition': 'transform 0s'
        });
    });
});

function refreshAnimation($wizard, index) {
    $total = $wizard.find('.nav li').length;
    $li_width = 100 / $total;

    total_steps = $wizard.find('.nav li').length;
    move_distance = $wizard.width() / total_steps;
    index_temp = index;
    vertical_level = 0;

    mobile_device = $(document).width() < 600 && $total > 3;

    if (mobile_device) {
        move_distance = $wizard.width() / 2;
        index_temp = index % 2;
        $li_width = 50;
    }

    $wizard.find('.nav li').css('width', $li_width + '%');

    step_width = move_distance;
    move_distance = move_distance * index_temp;

    $current = index + 1;

    if ($current == 1 || (mobile_device == true && (index % 2 == 0))) {
        move_distance -= 8;
    } else if ($current == total_steps || (mobile_device == true && (index % 2 == 1))) {
        move_distance += 8;
    }

    if (mobile_device) {
        vertical_level = parseInt(index / 2);
        vertical_level = vertical_level * 38;
    }

    $wizard.find('.moving-tab').css('width', step_width);
    $('.moving-tab').css({
        'transform': 'translate3d(' + move_distance + 'px, ' + vertical_level + 'px, 0)',
        'transition': 'all 0.5s cubic-bezier(0.29, 1.42, 0.79, 1)'

    });
}

materialDesign = {

    checkScrollForTransparentNavbar: debounce(function() {
        if ($(document).scrollTop() > 260) {
            if (transparent) {
                transparent = false;
                $('.navbar-color-on-scroll').removeClass('navbar-transparent');
            }
        } else {
            if (!transparent) {
                transparent = true;
                $('.navbar-color-on-scroll').addClass('navbar-transparent');
            }
        }
    }, 17)

}

function debounce(func, wait, immediate) {
    var timeout;
    return function() {
        var context = this,
            args = arguments;
        clearTimeout(timeout);
        timeout = setTimeout(function() {
            timeout = null;
            if (!immediate) func.apply(context, args);
        }, wait);
        if (immediate && !timeout) func.apply(context, args);
    };
};