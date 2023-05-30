// CSS PART:
// Responsive columns:
// grid-template-columns: repeat(auto-fill, minmax(24rem, 1fr));
//
// Responsive by screen size:
// @media sceen and (max-width: <size>) {
// 	<css queries>
// }

// JS PART:
// indexedDB (plain js file)
let db = null;

const getDatabase = (name, version, upgradeneeded) => {
    return new Promise((resolve, reject) => {
        const request = indexedDB.open(name, version);
        request.addEventListener("success", e => resolve(e.target.result));
        request.addEventListener("upgradeneeded", upgradeneeded);
        request.addEventListener("error", e => reject(e.target.errorCode));
    })
}

const initializeDatabase = (e) => {
    db = e.target.result;
    db.createObjectStore("{ // TODO: Change database name }", {keyPath: "id"});
}

// add to indexedDB (plain js file)
const table = "{ // TODO: Change table name }"
const database = await getDatabase("{ // TODO: Change database name }", 1, initializeDatabase);
const transaction = database.transaction(table, "readwrite");
const store = transaction.objectStore(table);
const os = store.add(recipe);

os.addEventListener("success", e => {
	// Added
});


// Regisering service worker (plain js file)
const registerServiceWorker = async () => {
  if ("serviceWorker" in navigator) {
    try {
      await navigator.serviceWorker.register("/sw.js");
      console.log("Service worker registered")
    } catch (e) {
      console.log("Service worker registration failed");
    }
  } else {
    console.log("Service worker not supported");
  }
}


// Synchronising things
// (plain js file)
if ('serviceWorker' in navigator && 'SyncManager' in window) {
	const swRegistration=  await navigator.serviceWorker.ready;
	return swRegistration.sync.register("{ // TODO: ID of event here }");
}

// TODO: If not allowed fallback method here

// sw.js file
self.addEventListener("sync", async e => {
    if (e.tag.startsWith("{ // TODO: ID of event here }")) {
	    // TODO: Perform appropriate action
    }
})


// Caching statically (sw.js file)
const CACHE_VERSION = 1;
const CACHE_PREFIX = "static-cache";
const CACHE_NAME = `${CACHE_PREFIX}-v${CACHE_VERSION}`;

const FILES_TO_CACHE = [
	"index.html"
	// TODO: Add pages to cache here
];

const populateCache = async () => {
    console.log("[SW] Caching pages statically.")
    const cache = await caches.open(CACHE_NAME);
    return cache.addAll(FILES_TO_CACHE);
}

self.addEventListener("install", (e) => {
    console.log("[SW] Installing service worker.")
    e.waitUntil(populateCache());
});


// Fetching resources offline (sw.js file)
const offlineFetch = async (request) => {
    try {
        return await fetch(request);
    } catch {
        console.log(`[SW] Fetching cached file. (${request.url})`)
        const cache = await caches.open(CACHE_NAME)
        return await cache.match(request);
    }
}

self.addEventListener("fetch", (e) => {
    e.respondWith(offlineFetch(e.request));
});


// Clearing the cache (sw.js file)
const clearCaches = async () => {
    const cacheNames = await caches.keys();
    for (let cacheName of cacheNames) {
        if (CACHE_NAME !== cacheName && cacheName.startsWith(CACHE_PREFIX))
            await caches.delete(cacheName);
    }
}

self.addEventListener("activate", (e) => {
    e.waitUntil(clearCaches())
});


// Communicating between client js and service worker
// (plain js file)
navigator.serviceWorker.controller.postMessage({
	action: "{ // TODO: My action ID here }",
	data: {
		// TODO: Add other properties for my action (optional)
	}
});

// (sw.js file)
self.addEventListener("message", async (e) => {
    if (e.data.action === "{ // TODO: My action ID here }") {
	    // TODO: Perform appropriate action here
    }
});


// urlBase64ToUint8Array helper method for the notifications (plain js file)
const urlBase64ToUint8Array = (base64String) => {
  const padding = '='.repeat((4 - base64String.length % 4) % 4);
  const base64 = (base64String + padding)
      .replace(/-/g, '+')
      .replace(/_/g, '/');
  const rawData = window.atob(base64);
  const outputArray = new Uint8Array(rawData.length);
  for (let i = 0; i < rawData.length; ++i) {
    outputArray[i] = rawData.charCodeAt(i);
  }
  return outputArray;
}


// Request notification permissions (plain js file)
const registerNotifications = async () => {
    await navigator.serviceWorker.ready;

    if ("Notification" in window) {
        const permission = await Notification.requestPermission();

        switch (permission) {
            case "granted":
                console.log("Notifications allowed");
                break;
            case "denied":
                console.log("Notifications denied");
                break;
            default:
                console.log("Notifications not supported");
                break;
        }
    }
}

// Receiving VAPID credentials (in a node terminal)
const webpush = require("web-push");
console.log(webpush.generateVAPIDKeys());


// Notifications
// (plain js file)
const VAPID_PUBLIC_KEY = "{ // TODO: Paste your public key here }"

const subscribeOptions = {
userVisibleOnly: true,
applicationServerKey: urlBase64ToUint8Array(VAPID_PUBLIC_KEY)
}

const registration = await navigator.serviceWorker.ready;
const subscription = await registration.pushManager.subscribe(subscribeOptions);
// TODO: Send the subscription to the server

// (sw.js file)
self.addEventListener("push", async (e) => {
    let data = e.data.json();
    await self.registration.showNotification(data.title, {
        body: data.body,
	icon: "{ // TODO: (OPTIONAL) Set icon url here}",
	data: {
		url:  "{ // TODO: (OPTIONAL) Set website url here}"
	}
    });
})

// endpoint code (server)
import webpush from "web-push";

const pushKeys = {
	// TODO: Content from VAPID keys generation paste here (publicKey, privateKey)
}

webpush.setVapidDetails(
    'mailto:{ // TODO: Set your email here }',
    pushKeys.publicKey,
    pushKeys.privateKey
);

// within the endpoint
const subcription = // TODO: Get the subscription from the body
const message = { 
	title: "{ // TODO: Set a notification title here }",
	body: "{ // TODO: Set a notification body here }",
	url: "{ // TODO: Set a notification url here }"
}

webpush.sendNotification(subscription, JSON.stringify(message));


// On notification click (sw.js file)
self.addEventListener("notificationClick", (e) => {
	e.notification.close();
	// TODO: Perform action, eg open the url.
	// clients.openWindow(e.notification.data.url);
});



