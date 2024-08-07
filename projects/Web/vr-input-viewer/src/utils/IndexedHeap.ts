/** Values added to heap must be unique (not two values exactly equal). */
export class IndexedHeap<T> {
  data: T[] = [];
  indexMap = new Map<T, number>();

  constructor(public comparator: (a: T, b: T) => number) {}

  /** O(1) */
  size(): number {
    return this.data.length;
  }

  /** O(1) */
  peek(): T | undefined {
    return this.data[0];
  }

  /** O(log n) */
  push(item: T): void {
    if (this.isDataBad(item)) throw "ahhhh";
    this.data.push(item);
    if (this.isDataBad()) throw "ahhhh";
    this.indexMap.set(item, this.data.length - 1);
    this.bubbleUp(this.data.length - 1);
  }

  /** O(log n) */
  pop(): T | undefined {
    if (this.data.length === 0) return undefined;
    const item = this.data[0];
    this.indexMap.delete(item);
    if (this.data.length > 0) {
      const last = this.data.pop()!;
      this.indexMap.delete(last);
      if (this.isDataBad(last)) throw "ahhhh";
      this.data[0] = last;
      if (this.isDataBad()) throw "ahhhh";
      this.indexMap.set(last, 0);
      this.siftDown(0);
    }
    return item;
  }

  /** O(log n) */
  delete(value: T): void {
    const index = this.indexMap.get(value);
    if (index === undefined) return;
    const end = this.data.pop();
    if (index === this.data.length || end === undefined) return;
    this.indexMap.delete(value);
    if (this.isDataBad(end)) throw "ahhhh";
    this.data[index] = end;
    if (this.isDataBad()) throw "ahhhh";
    this.indexMap.set(end, index);
    this.bubbleUp(index);
    this.siftDown(index);
  }

  private bubbleUp(index: number): void {
    const parentIndex = Math.floor((index - 1) / 2);
    if (
      parentIndex < 0 ||
      this.comparator(this.data[parentIndex], this.data[index]) <= 0
    )
      return;
    this.swap(index, parentIndex);
    this.bubbleUp(parentIndex);
  }

  private siftDown(index: number): void {
    const leftIndex = index * 2 + 1;
    const rightIndex = index * 2 + 2;
    let smallest = index;
    if (
      leftIndex < this.data.length &&
      this.comparator(this.data[smallest], this.data[leftIndex]) > 0
    ) {
      smallest = leftIndex;
    }
    if (
      rightIndex < this.data.length &&
      this.comparator(this.data[smallest], this.data[rightIndex]) > 0
    ) {
      smallest = rightIndex;
    }
    if (smallest !== index) {
      this.swap(index, smallest);
      this.siftDown(smallest);
    }
  }

  private swap(i: number, j: number): void {
    if (this.isDataBad(this.data[i])) throw "ahhhh";
    if (this.isDataBad(this.data[j])) throw "ahhhh";
    [this.data[i], this.data[j]] = [this.data[j], this.data[i]];
    if (this.isDataBad(this.data[i])) throw "ahhhh";
    if (this.isDataBad(this.data[j])) throw "ahhhh";
    this.indexMap.set(this.data[i], i);
    this.indexMap.set(this.data[j], j);
  }

  private isDataBad(value: unknown = true) {
    return (
      value === undefined ||
      (this.data.length > 2 &&
        (this.data[this.data.length - 1] === undefined ||
          this.data[this.data.length - 2] === undefined))
    );
  }
}
