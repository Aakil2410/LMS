"use client";
import Link from "next/link";
import { Button } from "antd";
import styles from "../Home.module.css";
import './Search.module.css'

import React, { useState } from "react";
import axios from "axios";
import Books from "./Books";

export default function SearchBook() {
  const [search, setSearch] = useState<string>("");
  const [bookData, setData] = useState<any[]>([]);
  const [searchBy, setSearchBy] = useState<string>("");

  const url: string = "https://www.googleapis.com/books/v1/volumes";
  const apiKey: string = "AIzaSyB4dzCYvU9Kb0hmH4SHc1x9I6alUnta4e8";
  let link: string;

  function handleSearchBy(event: React.ChangeEvent<HTMLInputElement>): void {
    setSearchBy(event.target.value);
  }

  const searchBook = (evt: React.KeyboardEvent<HTMLInputElement>): void => {
    let warning: string = "";
    if (evt.key === "Enter") {
      console.log(searchBy);

      let ISBNIsNum: boolean = false;
      switch (searchBy) {
        case "title":
          link = `${url}?key=${apiKey}&langRestrict=en&maxResults=40&orderBy=relevance&q=intitle:${search}`;

          break;

        case "author":
          link = `${url}?key=${apiKey}&langRestrict=en&maxResults=40&orderBy=relevance&q=inauthor:${search}`;

          break;

        case "publisher":
          link = `${url}?key=${apiKey}&langRestrict=en&maxResults=40&orderBy=relevance&q=inpublisher:${search}`;

          break;

        case "subject":
          link = `${url}?key=${apiKey}&langRestrict=en&maxResults=40&orderBy=relevance&q=subject:${search}`;

          break;

        case "isbn":
          if (isNaN(Number(search)) && ISBNIsNum == false) {
            warning = `${search} is not a valid ISBN number. Please enter a valid ISBN number`;
          } else {
            ISBNIsNum = true;
            link = `${url}?key=${apiKey}&langRestrict=en&maxResults=40&orderBy=relevance&q=isbn:${search}`;
          }
          break;

        default:
          link = `${url}?key=${apiKey}&langRestrict=en&maxResults=40&orderBy=relevance&q=${search}`;

          break;
      }

      axios
        .get(link)
        .then((res) => setData(res.data.items))
        .catch((err) => window.alert(warning));
    }
  };

  return (
    <div className={styles.container}>
      <header className={styles.header}>
        <div className={styles.libraryName}>Athenaeum of Wonders</div>
        <div className={styles.authButtons}>
          <Button href="/sign-in" className={styles.button}>
            Sign In
          </Button>
          <Button href="/sign-up" className={styles.button}>
            Sign Up
          </Button>
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
        <h1>Find a Book</h1>
        {/* Content of the home page */}

        <div className="search">
          <input
            type="text"
            placeholder="Enter Your Book Name"
            value={search}
            onChange={(e) => setSearch(e.target.value)}
            onKeyDown={searchBook}
            required
          />
          <Button onSubmit={searchBook} className={styles.button}>
            Search
          </Button>
          <br />
          <br />
        </div>
        <div className="filter">
          <label htmlFor="searchBy">Search Book by:</label>
          <br />
          <label htmlFor="title">
            <input
              type="radio"
              name="searchBy"
              value="title"
              checked={searchBy === "title"}
              onChange={handleSearchBy}
            />
            Title
          </label>
          &nbsp; &nbsp;
          <label htmlFor="author">
            <input
              type="radio"
              name="searchBy"
              value="author"
              checked={searchBy === "author"}
              onChange={handleSearchBy}
            />
            Author
          </label>
          &nbsp; &nbsp;
          <label htmlFor="publisher">
            <input
              type="radio"
              name="searchBy"
              value="publisher"
              checked={searchBy === "publisher"}
              onChange={handleSearchBy}
            />
            Publisher
          </label>
          &nbsp; &nbsp;
          <label htmlFor="subject">
            <input
              type="radio"
              name="searchBy"
              value="subject"
              checked={searchBy === "subject"}
              onChange={handleSearchBy}
            />
            Subject
          </label>
          &nbsp; &nbsp;
          <label htmlFor="isbn">
            <input
              type="radio"
              name="searchBy"
              value="isbn"
              checked={searchBy === "isbn"}
              onChange={handleSearchBy}
            />
            ISBN
          </label>
        </div>

        <div className="books">
          {<Books book={bookData} />}
        </div>

      </main>

      <footer className={styles.footer}>
        <p>© 2024 Athenaeum of Wonders. All rights reserved.</p>
        <p>Explore the world through books and beyond.</p>
        {/* Add any additional components here */}
      </footer>
    </div>
  );
}
