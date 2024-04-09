// pages/index.tsx
import Link from 'next/link';
import { Button } from 'antd';
import styles from './Home.module.css';

const Home = () => {
  return (
    <div className={styles.container}>
      <header className={styles.header}>
        <div className={styles.libraryName}>Athenaeum of Wonders</div>
        <div className={styles.authButtons}>
        <Button href="/sign-in" className={styles.button} >Sign In</Button>
        <Button href="/sign-up" className={styles.button} >Sign Up</Button>
        </div>
      </header>
      <nav className={styles.navbar}>
        <Link href="/">Home</Link>
        <Link href="/search-book">Search Book</Link>
        <Link href="/reserve-book">Reserve a Book</Link>
        <Link href="/about">About</Link>
        <Link href="/contact">Contact</Link>
        {/* Add any additional pages here */}
      </nav>
      <main className={styles.main}>
        <h1>Find Happiness In Turning Pages</h1>
        {/* Content of the home page */}
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas eaque consequuntur necessitatibus ipsa ullam unde obcaecati voluptate, placeat beatae quia possimus reiciendis quam tenetur nemo at iure aliquam totam repellat!
        <h1>
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas eaque consequuntur necessitatibus ipsa ullam unde obcaecati voluptate, placeat beatae quia possimus reiciendis quam tenetur nemo at iure aliquam totam repellat!
        </h1>
        <h1>
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas eaque consequuntur necessitatibus ipsa ullam unde obcaecati voluptate, placeat beatae quia possimus reiciendis quam tenetur nemo at iure aliquam totam repellat!
        </h1>
        <h1>
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas eaque consequuntur necessitatibus ipsa ullam unde obcaecati voluptate, placeat beatae quia possimus reiciendis quam tenetur nemo at iure aliquam totam repellat!
        </h1>
      </main>







      <footer className={styles.footer}>
        <p>© 2024 Athenaeum of Wonders. All rights reserved.</p>
        <p>Explore the world through books and beyond.</p>
        {/* Add any additional components here */}
      </footer>
    </div>
  );
};

export default Home;