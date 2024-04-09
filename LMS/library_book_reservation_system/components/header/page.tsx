
import { Button } from 'antd';
import styles from './Header.module.css';


export default function Header() {
  return (
    <>
      <header className={styles.header}>
        <div className={styles.libraryName}>Athenaeum of Wonders</div>
        <div className={styles.authButtons}>
          <Button href="/sign-in" className={styles.button}>
            Sign In
          </Button>
          <Button href="/auth/sign-up" className={styles.button}>
            Sign Up
          </Button>
        </div>
      </header>
    </>
  );
}
