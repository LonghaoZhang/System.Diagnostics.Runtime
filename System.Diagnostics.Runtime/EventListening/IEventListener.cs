﻿using System.Diagnostics.Tracing;

namespace System.Diagnostics.Runtime.EventListening;

public interface IEventListener
{
    /// <summary>
    /// The name of the event source to receive events from.
    /// </summary>
    string EventSourceName { get; }

    /// <summary>
    /// The keywords to enable in the event source.
    /// </summary>
    /// <remarks>
    /// Keywords act as a "if-any-match" filter- specify multiple keywords to obtain multiple categories of events
    /// from the event source.
    /// </remarks>
    EventKeywords Keywords { get; }

    /// <summary>
    /// Process a received event.
    /// </summary>
    /// <remarks>
    /// Implementors should listen to events and perform some kind of processing.
    /// </remarks>
    void ProcessEvent(EventWrittenEventArgs e);
}
