import Link from 'next/link';
import styles from './Navbar.module.css';

export default function Navbar(){
    return(
        <>
        <nav className={styles.navbar}>
        <Link href="/">Home</Link>
        <Link href="/search-book">Search Book</Link>
        <Link href="/reserve-book">Reserve a Book</Link>
        <Link href="/about">About</Link>
        <Link href="/contact">Contact</Link>
        {/* Add any additional pages here */}
      </nav>
        </>
    );
}