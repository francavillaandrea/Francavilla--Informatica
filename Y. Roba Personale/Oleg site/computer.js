document.addEventListener('DOMContentLoaded', function() {
    // Initialize Three.js scene
    let scene, camera, renderer, workstation;
    let rotationY = 20;
    let lightsOn = true;
    
    function initScene() {
        // Get container
        const container = document.getElementById('scene-container');
        
        // Create scene
        scene = new THREE.Scene();
        scene.background = new THREE.Color(0xf8f9fa);
        
        // Create camera
        camera = new THREE.PerspectiveCamera(75, container.clientWidth / container.clientHeight, 0.1, 1000);
        camera.position.z = 800;
        
        // Create renderer
        renderer = new THREE.WebGLRenderer({ antialias: true, alpha: true });
        renderer.setSize(container.clientWidth, container.clientHeight);
        container.appendChild(renderer.domElement);
        
        // Create workstation group
        workstation = new THREE.Group();
        scene.add(workstation);
        
        // Create monitor
        createMonitor();
        
        // Create tower
        createTower();
        
        // Create keyboard
        createKeyboard();
        
        // Create mouse
        createMouse();
        
        // Create desk
        createDesk();
        
        // Add lights
        addLights();
        
        // Add controls
        setupControls();
        
        // Handle window resize
        window.addEventListener('resize', onWindowResize);
        
        // Start animation loop
        animate();
    }
    
    function createMonitor() {
        const monitorGroup = new THREE.Group();
        
        // Screen
        const screenGeometry = new THREE.BoxGeometry(300, 200, 10);
        const screenMaterial = new THREE.MeshPhongMaterial({ 
            color: 0x1a1a2e,
            emissive: 0x1a1a2e,
            emissiveIntensity: 0.2
        });
        const screen = new THREE.Mesh(screenGeometry, screenMaterial);
        screen.position.y = 50;
        monitorGroup.add(screen);
        
        // Add code texture to screen
        const codeCanvas = createCodeTexture();
        const codeTexture = new THREE.CanvasTexture(codeCanvas);
        const codeMaterial = new THREE.MeshBasicMaterial({ 
            map: codeTexture,
            transparent: true,
            opacity: 0.9
        });
        const codePlane = new THREE.Mesh(
            new THREE.PlaneGeometry(290, 190),
            codeMaterial
        );
        codePlane.position.set(0, 50, 6);
        monitorGroup.add(codePlane);
        
        // Monitor frame
        const frameGeometry = new THREE.BoxGeometry(320, 240, 20);
        const frameMaterial = new THREE.MeshPhongMaterial({ color: 0x333333 });
        const frame = new THREE.Mesh(frameGeometry, frameMaterial);
        monitorGroup.add(frame);
        
        // Stand
        const standGeometry = new THREE.CylinderGeometry(10, 50, 80, 4);
        const standMaterial = new THREE.MeshPhongMaterial({ color: 0x444444 });
        const stand = new THREE.Mesh(standGeometry, standMaterial);
        stand.position.y = -120;
        stand.rotation.x = Math.PI / 2;
        monitorGroup.add(stand);
        
        // Base
        const baseGeometry = new THREE.BoxGeometry(100, 10, 100);
        const baseMaterial = new THREE.MeshPhongMaterial({ color: 0x222222 });
        const base = new THREE.Mesh(baseGeometry, baseMaterial);
        base.position.y = -160;
        monitorGroup.add(base);
        
        monitorGroup.position.set(0, 0, 100);
        workstation.add(monitorGroup);
    }
    
    function createCodeTexture() {
        const canvas = document.createElement('canvas');
        canvas.width = 800;
        canvas.height = 600;
        const ctx = canvas.getContext('2d');
        
        // Background
        ctx.fillStyle = '#1a1a2e';
        ctx.fillRect(0, 0, canvas.width, canvas.height);
        
        // Code text
        const code = `// SPDX-License-Identifier: MIT
pragma solidity ^0.8.0;

contract MorfToken {
    string public name = "MorfToken";
    string public symbol = "MORF";
    uint8 public decimals = 18;
    uint256 public totalSupply = 1000000 * 10**decimals;
    
    mapping(address => uint256) public balanceOf;
    mapping(address => mapping(address => uint256)) public allowance;
    
    event Transfer(address indexed from, address indexed to, uint256 value);
    event Approval(address indexed owner, address indexed spender, uint256 value);
    
    constructor() {
        balanceOf[msg.sender] = totalSupply;
    }
    
    function transfer(address to, uint256 value) external returns (bool) {
        require(balanceOf[msg.sender] >= value, "Insufficient balance");
        balanceOf[msg.sender] -= value;
        balanceOf[to] += value;
        emit Transfer(msg.sender, to, value);
        return true;
    }
}`;
        
        // Draw code
        ctx.font = '16px "Courier New", monospace';
        const lines = code.split('\n');
        const colors = {
            comment: '#6C757D',
            keyword: '#FF6584',
            string: '#28A745',
            default: '#6C63FF'
        };
        
        let y = 40;
        lines.forEach(line => {
            let x = 20;
            const words = line.split(/(\/\/|\"|\'|\{|\}|\(|\)|;|,|\s+)/);
            
            words.forEach(word => {
                if (!word) return;
                
                let color = colors.default;
                if (word.startsWith('//')) color = colors.comment;
                else if (['pragma', 'contract', 'string', 'uint8', 'uint256', 'mapping', 'event', 
                          'constructor', 'function', 'external', 'returns', 'require', 'emit'].includes(word)) {
                    color = colors.keyword;
                } else if (word.startsWith('"') || word.startsWith("'")) {
                    color = colors.string;
                }
                
                ctx.fillStyle = color;
                ctx.fillText(word, x, y);
                x += ctx.measureText(word).width;
            });
            
            y += 24;
        });
        
        return canvas;
    }
    
    function createTower() {
        const towerGroup = new THREE.Group();
        
        // Main tower
        const towerGeometry = new THREE.BoxGeometry(120, 300, 60);
        const towerMaterial = new THREE.MeshPhongMaterial({ 
            color: 0x222222,
            shininess: 30
        });
        const tower = new THREE.Mesh(towerGeometry, towerMaterial);
        towerGroup.add(tower);
        
        // Front panel
        const frontGeometry = new THREE.BoxGeometry(110, 290, 1);
        const frontMaterial = new THREE.MeshPhongMaterial({ 
            color: 0x333333,
            emissive: 0x111111,
            emissiveIntensity: 0.1
        });
        const front = new THREE.Mesh(frontGeometry, frontMaterial);
        front.position.z = 30.5;
        towerGroup.add(front);
        
        // RGB lighting
        const rgbLightGeometry = new THREE.BoxGeometry(5, 290, 5);
        const rgbLightMaterial = new THREE.MeshPhongMaterial({ 
            color: 0x6C63FF,
            emissive: 0x6C63FF,
            emissiveIntensity: 0.8
        });
        const rgbLight = new THREE.Mesh(rgbLightGeometry, rgbLightMaterial);
        rgbLight.position.set(62.5, 0, 0);
        towerGroup.add(rgbLight);
        
        // Animation for RGB
        const rgbColors = [0x6C63FF, 0xFF6584, 0x00FF88, 0xFFCC00];
        let colorIndex = 0;
        
        setInterval(() => {
            colorIndex = (colorIndex + 1) % rgbColors.length;
            rgbLight.material.color.setHex(rgbColors[colorIndex]);
            rgbLight.material.emissive.setHex(rgbColors[colorIndex]);
        }, 2000);
        
        towerGroup.position.set(-200, 0, -100);
        workstation.add(towerGroup);
    }
    
    function createKeyboard() {
        const keyboardGroup = new THREE.Group();
        
        // Base
        const baseGeometry = new THREE.BoxGeometry(300, 10, 100);
        const baseMaterial = new THREE.MeshPhongMaterial({ 
            color: 0x333333,
            shininess: 50
        });
        const base = new THREE.Mesh(baseGeometry, baseMaterial);
        keyboardGroup.add(base);
        
        // Keys
        const keyGeometry = new THREE.BoxGeometry(15, 2, 15);
        const keyMaterial = new THREE.MeshPhongMaterial({ color: 0x111111 });
        
        for (let row = 0; row < 5; row++) {
            for (let col = 0; col < 15; col++) {
                const key = new THREE.Mesh(keyGeometry, keyMaterial);
                key.position.set(
                    -140 + col * 20,
                    6,
                    -40 + row * 20
                );
                keyboardGroup.add(key);
            }
        }
        
        keyboardGroup.position.set(0, -100, 50);
        workstation.add(keyboardGroup);
    }
    
    function createMouse() {
        const mouseGroup = new THREE.Group();
        
        // Base
        const baseGeometry = new THREE.SphereGeometry(30, 32, 32, 0, Math.PI * 2, 0, Math.PI / 2);
        const baseMaterial = new THREE.MeshPhongMaterial({ 
            color: 0x333333,
            shininess: 100
        });
        const base = new THREE.Mesh(baseGeometry, baseMaterial);
        base.rotation.x = Math.PI;
        mouseGroup.add(base);
        
        // Top
        const topGeometry = new THREE.SphereGeometry(28, 32, 32, 0, Math.PI * 2, 0, Math.PI / 3);
        const topMaterial = new THREE.MeshPhongMaterial({ 
            color: 0x222222,
            shininess: 50
        });
        const top = new THREE.Mesh(topGeometry, topMaterial);
        top.rotation.x = Math.PI;
        top.position.z = -5;
        mouseGroup.add(top);
        
        // Scroll wheel
        const wheelGeometry = new THREE.TorusGeometry(5, 1, 16, 32);
        const wheelMaterial = new THREE.MeshPhongMaterial({ color: 0x111111 });
        const wheel = new THREE.Mesh(wheelGeometry, wheelMaterial);
        wheel.rotation.x = Math.PI / 2;
        wheel.position.set(0, 25, -10);
        mouseGroup.add(wheel);
        
        mouseGroup.position.set(200, -100, 50);
        mouseGroup.rotation.z = Math.PI / 6;
        workstation.add(mouseGroup);
    }
    
    function createDesk() {
        const deskGeometry = new THREE.BoxGeometry(800, 20, 400);
        const deskMaterial = new THREE.MeshPhongMaterial({ 
            color: 0x3a3a3a,
            shininess: 20
        });
        const desk = new THREE.Mesh(deskGeometry, deskMaterial);
        desk.position.set(0, -200, -100);
        desk.rotation.x = Math.PI / 6;
        workstation.add(desk);
    }
    
    function addLights() {
        // Ambient light
        const ambientLight = new THREE.AmbientLight(0x404040);
        scene.add(ambientLight);
        
        // Directional light
        const directionalLight = new THREE.DirectionalLight(0xffffff, 0.8);
        directionalLight.position.set(1, 1, 1);
        scene.add(directionalLight);
        
        // RGB monitor backlight
        const backLight = new THREE.PointLight(0x6C63FF, 1, 200);
        backLight.position.set(0, 50, -50);
        workstation.add(backLight);
        
        // Tower RGB light effect
        const towerLight = new THREE.PointLight(0x6C63FF, 0.5, 100);
        towerLight.position.set(-200, 0, -100);
        workstation.add(towerLight);
    }
    
    function setupControls() {
        const rotateLeft = document.getElementById('rotate-left');
        const rotateRight = document.getElementById('rotate-right');
        const resetView = document.getElementById('reset-view');
        const toggleLights = document.getElementById('toggle-lights');
        
        rotateLeft.addEventListener('click', () => {
            rotationY -= 45;
            gsap.to(workstation.rotation, {
                y: THREE.MathUtils.degToRad(rotationY),
                duration: 0.8,
                ease: 'power2.inOut'
            });
        });
        
        rotateRight.addEventListener('click', () => {
            rotationY += 45;
            gsap.to(workstation.rotation, {
                y: THREE.MathUtils.degToRad(rotationY),
                duration: 0.8,
                ease: 'power2.inOut'
            });
        });
        
        resetView.addEventListener('click', () => {
            rotationY = 20;
            gsap.to(workstation.rotation, {
                y: THREE.MathUtils.degToRad(rotationY),
                duration: 0.8,
                ease: 'elastic.out(1, 0.5)'
            });
        });
        
        toggleLights.addEventListener('click', () => {
            lightsOn = !lightsOn;
            scene.traverse(obj => {
                if (obj.isLight) {
                    obj.visible = lightsOn;
                }
            });
            toggleLights.innerHTML = lightsOn ? 
                '<i class="fas fa-lightbulb"></i> Lights On' : 
                '<i class="far fa-lightbulb"></i> Lights Off';
        });
    }
    
    function onWindowResize() {
        const container = document.getElementById('scene-container');
        camera.aspect = container.clientWidth / container.clientHeight;
        camera.updateProjectionMatrix();
        renderer.setSize(container.clientWidth, container.clientHeight);
    }
    
    function animate() {
        requestAnimationFrame(animate);
        renderer.render(scene, camera);
    }
    
    // Initialize the scene
    initScene();
});