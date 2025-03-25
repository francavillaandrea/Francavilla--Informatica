document.addEventListener('DOMContentLoaded', function() {
    // Preloader
    const preloader = document.querySelector('.preloader');
    
    // Hide preloader when page is loaded
    window.addEventListener('load', function() {
        gsap.to(preloader, {
            opacity: 0,
            duration: 0.6,
            ease: 'power2.out',
            onComplete: function() {
                preloader.style.display = 'none';
                document.body.style.overflow = 'auto';
                animateHero();
            }
        });
    });

    // Initialize Particle.js
    if (document.getElementById('particles-js')) {
        particlesJS('particles-js', {
            particles: {
                number: { value: 80, density: { enable: true, value_area: 800 } },
                color: { value: "#6C63FF" },
                shape: { type: "circle" },
                opacity: { value: 0.5, random: true },
                size: { value: 3, random: true },
                line_linked: { enable: true, distance: 150, color: "#6C63FF", opacity: 0.4, width: 1 },
                move: { enable: true, speed: 2, direction: "none", random: true, straight: false, out_mode: "out" }
            },
            interactivity: {
                detect_on: "canvas",
                events: {
                    onhover: { enable: true, mode: "repulse" },
                    onclick: { enable: true, mode: "push" }
                }
            }
        });
    }

    // Custom Cursor
    const cursorOuter = document.querySelector('.cursor-outer');
    const cursorInner = document.querySelector('.cursor-inner');
    let mouseX = 0, mouseY = 0;
    let outerX = 0, outerY = 0;
    const delay = 0.1;

    document.addEventListener('mousemove', function(e) {
        mouseX = e.clientX;
        mouseY = e.clientY;
        cursorInner.style.left = mouseX + 'px';
        cursorInner.style.top = mouseY + 'px';
    });

    function animateCursor() {
        let distX = mouseX - outerX;
        let distY = mouseY - outerY;
        
        outerX = outerX + (distX * delay);
        outerY = outerY + (distY * delay);
        
        cursorOuter.style.left = outerX + 'px';
        cursorOuter.style.top = outerY + 'px';
        
        requestAnimationFrame(animateCursor);
    }
    animateCursor();

    // Cursor hover effects
    const hoverElements = document.querySelectorAll('a, button, .work-item, .timeline-item, .certification-item');
    
    hoverElements.forEach(el => {
        el.addEventListener('mouseenter', () => {
            cursorOuter.classList.add('cursor-active');
        });
        el.addEventListener('mouseleave', () => {
            cursorOuter.classList.remove('cursor-active');
        });
    });

    // Magnetic button effect
    const magneticButtons = document.querySelectorAll('.magnetic');
    
    magneticButtons.forEach(button => {
        button.addEventListener('mousemove', function(e) {
            const rect = this.getBoundingClientRect();
            const x = e.clientX - rect.left;
            const y = e.clientY - rect.top;
            const centerX = rect.width / 2;
            const centerY = rect.height / 2;
            const angleX = (centerY - y) / 8;
            const angleY = (x - centerX) / 8;
            
            gsap.to(this, {
                x: angleY,
                y: angleX,
                duration: 0.5,
                ease: 'power2.out'
            });
        });
        
        button.addEventListener('mouseleave', function() {
            gsap.to(this, {
                x: 0,
                y: 0,
                duration: 0.7,
                ease: 'elastic.out(1, 0.5)'
            });
        });
    });

    // Theme toggle
    const themeToggle = document.querySelector('.theme-toggle');
    const currentTheme = localStorage.getItem('theme') || 'light';
    
    document.documentElement.setAttribute('data-theme', currentTheme);
    
    themeToggle.addEventListener('click', function() {
        const currentTheme = document.documentElement.getAttribute('data-theme');
        const newTheme = currentTheme === 'light' ? 'dark' : 'light';
        
        document.documentElement.setAttribute('data-theme', newTheme);
        localStorage.setItem('theme', newTheme);
        
        if (newTheme === 'dark') {
            this.innerHTML = '<i class="fas fa-sun"></i>';
        } else {
            this.innerHTML = '<i class="fas fa-moon"></i>';
        }
        
        // Animate theme transition
        gsap.from('body', {
            background: currentTheme === 'light' ? '#F8F9FA' : '#1A1A2E',
            duration: 0.5,
            ease: 'power2.inOut'
        });
    });

    // Mobile menu toggle
    const burger = document.querySelector('.burger');
    const navLinks = document.querySelector('.nav-links');
    
    burger.addEventListener('click', function() {
        this.classList.toggle('active');
        navLinks.classList.toggle('active');
        document.body.style.overflow = navLinks.classList.contains('active') ? 'hidden' : 'auto';
    });

    // Close mobile menu when clicking on a link
    document.querySelectorAll('.nav-links a').forEach(link => {
        link.addEventListener('click', function() {
            burger.classList.remove('active');
            navLinks.classList.remove('active');
            document.body.style.overflow = 'auto';
        });
    });

    // Animate hero section
    function animateHero() {
        // Animate title words
        const titleWords = document.querySelectorAll('.word');
        
        gsap.from(titleWords, {
            y: 100,
            opacity: 0,
            duration: 1.2,
            ease: 'power3.out',
            stagger: 0.1,
            delay: 0.3
        });
        
        // Typing animation
        const typingText = document.querySelector('.typing-text');
        const strings = typingText.getAttribute('data-strings');
        const stringsArray = JSON.parse(strings.replace(/'/g, '"'));
        
        let currentString = 0;
        let currentChar = 0;
        let isDeleting = false;
        let isEnd = false;
        
        function type() {
            isEnd = false;
            typingText.textContent = stringsArray[currentString].substring(0, currentChar);
            
            if (!isDeleting && currentChar === stringsArray[currentString].length) {
                isEnd = true;
                isDeleting = true;
                setTimeout(type, 2000);
            } else if (isDeleting && currentChar === 0) {
                isDeleting = false;
                currentString = (currentString + 1) % stringsArray.length;
                setTimeout(type, 500);
            } else {
                if (isDeleting) {
                    currentChar--;
                } else {
                    currentChar++;
                }
                
                const speed = isDeleting ? 50 : isEnd ? 1000 : 100;
                setTimeout(type, speed);
            }
        }
        
        setTimeout(type, 1500);
    }

    // Animate stats counting
    const statNumbers = document.querySelectorAll('.stat-number');
    
    function animateStats() {
        statNumbers.forEach(stat => {
            const target = parseInt(stat.getAttribute('data-count'));
            const duration = 2000;
            const startTime = Date.now();
            
            function updateNumber() {
                const currentTime = Date.now();
                const elapsed = currentTime - startTime;
                const progress = Math.min(elapsed / duration, 1);
                const value = Math.floor(progress * target);
                
                stat.textContent = value;
                
                if (progress < 1) {
                    requestAnimationFrame(updateNumber);
                }
            }
            
            updateNumber();
        });
    }

    // Initialize skills sphere
    function initSkillsSphere() {
        const skillsSphere = document.getElementById('skills-sphere');
        if (!skillsSphere) return;
        
        const skills = [
            'JavaScript', 'TypeScript', 'React', 'Next.js', 'Node.js',
            'Express', 'GraphQL', 'Python', 'Django', 'Solidity',
            'Ethereum', 'Web3.js', 'Three.js', 'GSAP', 'CSS3',
            'SASS', 'Tailwind', 'MongoDB', 'PostgreSQL', 'Docker',
            'AWS', 'Git', 'CI/CD', 'Jest', 'Cypress'
        ];
        
        const sphere = TagSphere(skillsSphere, skills, {
            radius: 250,
            maxSpeed: 0.03,
            initialSpeed: 0.01,
            initialDirection: [0.1, 0.2],
            keepRollingAfterMouseOut: true
        });
    }

    // Initialize Swiper for testimonials
    function initTestimonialSlider() {
        const swiper = new Swiper('.testimonial-slider', {
            loop: true,
            autoplay: {
                delay: 5000,
                disableOnInteraction: false
            },
            pagination: {
                el: '.swiper-pagination',
                clickable: true
            },
            effect: 'fade',
            fadeEffect: {
                crossFade: true
            }
        });
    }

    // Filter work items
    function filterWork() {
        const filterButtons = document.querySelectorAll('.filter-btn');
        const workItems = document.querySelectorAll('.work-item');
        
        filterButtons.forEach(button => {
            button.addEventListener('click', function() {
                // Update active button
                filterButtons.forEach(btn => btn.classList.remove('active'));
                this.classList.add('active');
                
                const filter = this.getAttribute('data-filter');
                
                // Filter items
                workItems.forEach(item => {
                    if (filter === 'all' || item.classList.contains(filter)) {
                        gsap.to(item, {
                            opacity: 1,
                            scale: 1,
                            display: 'block',
                            duration: 0.4,
                            ease: 'power2.out'
                        });
                    } else {
                        gsap.to(item, {
                            opacity: 0,
                            scale: 0.8,
                            display: 'none',
                            duration: 0.4,
                            ease: 'power2.in'
                        });
                    }
                });
            });
        });
    }

    // Form submission
    function handleFormSubmission() {
        const form = document.getElementById('project-form');
        if (!form) return;
        
        form.addEventListener('submit', function(e) {
            e.preventDefault();
            
            const submitButton = this.querySelector('button[type="submit"]');
            const originalText = submitButton.innerHTML;
            
            // Show loading state
            submitButton.innerHTML = '<i class="fas fa-spinner fa-spin"></i> Sending...';
            submitButton.disabled = true;
            
            // Simulate form submission
            setTimeout(() => {
                submitButton.innerHTML = '<i class="fas fa-check"></i> Message Sent!';
                
                // Reset form
                setTimeout(() => {
                    form.reset();
                    submitButton.innerHTML = originalText;
                    submitButton.disabled = false;
                    
                    // Show success notification
                    const notification = document.createElement('div');
                    notification.className = 'form-notification success';
                    notification.innerHTML = 'Your message has been sent successfully!';
                    form.appendChild(notification);
                    
                    setTimeout(() => {
                        notification.style.opacity = '0';
                        setTimeout(() => notification.remove(), 500);
                    }, 3000);
                }, 2000);
            }, 1500);
        });
    }

    // Scroll animations
    function initScrollAnimations() {
        const sections = document.querySelectorAll('.section');
        
        sections.forEach(section => {
            gsap.from(section, {
                scrollTrigger: {
                    trigger: section,
                    start: 'top 80%',
                    toggleActions: 'play none none none'
                },
                opacity: 0,
                y: 50,
                duration: 1,
                ease: 'power2.out'
            });
        });
    }

    // Initialize all functions
    function init() {
        animateStats();
        initSkillsSphere();
        initTestimonialSlider();
        filterWork();
        handleFormSubmission();
        initScrollAnimations();
    }

    // Wait for everything to load
    window.addEventListener('load', init);
});

// TagSphere for skills visualization
function TagSphere(element, texts, settings) {
    const self = this;
    const defaultSettings = {
        radius: 200,
        maxSpeed: 0.05,
        initialSpeed: 0.03,
        initialDirection: [0.1, 0.2],
        keepRollingAfterMouseOut: true
    };
    
    settings = Object.assign({}, defaultSettings, settings);
    
    const width = element.offsetWidth;
    const height = element.offsetHeight;
    const tags = [];
    const tagElements = [];
    let angleX = 0;
    let angleY = 0;
    let lastTime;
    let mouseX = 0;
    let mouseY = 0;
    let speed = settings.initialSpeed;
    let direction = settings.initialDirection;
    let rolling = true;
    
    // Create tags
    texts.forEach((text, i) => {
        const tag = {};
        tag.text = text;
        tag.phi = Math.acos(-1 + (2 * i + 1) / texts.length);
        tag.theta = Math.sqrt(texts.length * Math.PI) * tag.phi;
        tag.element = document.createElement('div');
        tag.element.className = 'tag';
        tag.element.textContent = tag.text;
        tag.element.style.color = `hsl(${i * 360 / texts.length}, 70%, 60%)`;
        element.appendChild(tag.element);
        tags.push(tag);
        tagElements.push(tag.element);
    });
    
    // Position tags
    function update() {
        const time = new Date().getTime();
        const delta = lastTime ? time - lastTime : 0;
        lastTime = time;
        
        angleX += direction[0] * speed * (delta / 30);
        angleY += direction[1] * speed * (delta / 30);
        
        tags.forEach(tag => {
            const cosPhi = Math.cos(tag.phi);
            const sinPhi = Math.sin(tag.phi);
            const cosTheta = Math.cos(tag.theta + angleY);
            const sinTheta = Math.sin(tag.theta + angleY);
            const cosAngleX = Math.cos(angleX);
            const sinAngleX = Math.sin(angleX);
            
            const x = settings.radius * sinPhi * cosTheta;
            const y = settings.radius * (cosAngleX * cosPhi + sinAngleX * sinPhi * sinTheta);
            const z = settings.radius * (sinAngleX * cosPhi - cosAngleX * sinPhi * sinTheta);
            
            const scale = settings.radius / (settings.radius + z);
            const alpha = (z + settings.radius) / (2 * settings.radius);
            
            tag.element.style.transform = `translate(-50%, -50%) translate3d(${x}px, ${y}px, 0) scale(${scale})`;
            tag.element.style.opacity = alpha + 0.5;
            tag.element.style.zIndex = Math.floor(scale * 100);
        });
    }
    
    // Handle mouse events
    function onMouseMove(e) {
        if (!rolling) return;
        
        const rect = element.getBoundingClientRect();
        mouseX = (e.clientX - (rect.left + rect.width / 2)) / 100;
        mouseY = (e.clientY - (rect.top + rect.height / 2)) / 100;
        
        direction = [mouseX, -mouseY];
        speed = settings.maxSpeed;
    }
    
    function onMouseOut() {
        if (!settings.keepRollingAfterMouseOut) {
            rolling = false;
            speed = 0;
        } else {
            speed = settings.initialSpeed;
            direction = settings.initialDirection;
        }
    }
    
    element.addEventListener('mousemove', onMouseMove);
    element.addEventListener('mouseout', onMouseOut);
    
    // Animation loop
    function animate() {
        requestAnimationFrame(animate);
        update();
    }
    
    animate();
    
    return {
        element,
        tags,
        update,
        start: () => { rolling = true; },
        stop: () => { rolling = false; }
    };
}